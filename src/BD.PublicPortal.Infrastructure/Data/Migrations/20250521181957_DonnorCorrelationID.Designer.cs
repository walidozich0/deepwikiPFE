﻿// <auto-generated />
using System;
using BD.PublicPortal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BD.PublicPortal.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250521181957_DonnorCorrelationID")]
    partial class DonnorCorrelationID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<int?>("CommuneId")
                        .HasColumnType("integer")
                        .HasColumnName("CommuneId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<Guid?>("CorrelationId")
                        .HasColumnType("uuid")
                        .HasColumnName("CorrelationId");

                    b.Property<int?>("DonorAvailability")
                        .HasColumnType("integer")
                        .HasColumnName("DonorAvailability");

                    b.Property<DateTime>("DonorBirthDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DonorBirthDate");

                    b.Property<int>("DonorBloodGroup")
                        .HasColumnType("integer")
                        .HasColumnName("DonorBloodGroup");

                    b.Property<int?>("DonorContactMethod")
                        .HasColumnType("integer")
                        .HasColumnName("DonorContactMethod");

                    b.Property<bool>("DonorExcludeFromPublicPortal")
                        .HasColumnType("boolean")
                        .HasColumnName("DonorExcludeFromPublicPortal");

                    b.Property<DateTime?>("DonorLastDonationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DonorLastDonationDate");

                    b.Property<string>("DonorNIN")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DonorNIN");

                    b.Property<string>("DonorName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DonorName");

                    b.Property<string>("DonorNotesForBTC")
                        .HasColumnType("text")
                        .HasColumnName("DonorNotesForBTC");

                    b.Property<string>("DonorTel")
                        .HasColumnType("text")
                        .HasColumnName("DonorTel");

                    b.Property<bool>("DonorWantToStayAnonymous")
                        .HasColumnType("boolean")
                        .HasColumnName("DonorWantToStayAnonymous");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean")
                        .HasColumnName("IsAdmin");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("CommuneId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodDonationPledge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("ApplicationUserId");

                    b.Property<Guid>("BloodDonationRequestId")
                        .HasColumnType("uuid")
                        .HasColumnName("BloodDonationRequestId");

                    b.Property<string>("CantBeDoneReason")
                        .HasColumnType("text")
                        .HasColumnName("CantBeDoneReason");

                    b.Property<int>("EvolutionStatus")
                        .HasColumnType("integer")
                        .HasColumnName("EvolutionStatus");

                    b.Property<DateTime?>("PledgeDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("PledgeDate");

                    b.Property<DateTime?>("PledgeHonoredOrCanceledDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("PledgeHonoredOrCanceledDate");

                    b.Property<DateTime>("PledgeInitiatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("PledgeInitiatedDate");

                    b.Property<string>("PledgeNotes")
                        .HasColumnType("text")
                        .HasColumnName("PledgeNotes");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("BloodDonationRequestId");

                    b.ToTable("BloodDonationPledges", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodDonationRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<int>("BloodGroup")
                        .HasColumnType("integer")
                        .HasColumnName("BloodGroup");

                    b.Property<Guid>("BloodTansfusionCenterId")
                        .HasColumnType("uuid")
                        .HasColumnName("BloodTansfusionCenterId");

                    b.Property<int>("DonationType")
                        .HasColumnType("integer")
                        .HasColumnName("DonationType");

                    b.Property<int?>("EvolutionStatus")
                        .HasColumnType("integer")
                        .HasColumnName("EvolutionStatus");

                    b.Property<string>("MoreDetails")
                        .HasColumnType("text")
                        .HasColumnName("MoreDetails");

                    b.Property<int>("Priority")
                        .HasColumnType("integer")
                        .HasColumnName("Priority");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("RequestDate");

                    b.Property<DateTime?>("RequestDueDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("RequestDueDate");

                    b.Property<int>("RequestedQty")
                        .HasColumnType("integer")
                        .HasColumnName("RequestedQty");

                    b.Property<string>("ServiceName")
                        .HasColumnType("text")
                        .HasColumnName("ServiceName");

                    b.HasKey("Id");

                    b.HasIndex("BloodTansfusionCenterId");

                    b.ToTable("BloodDonationRequests", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodInventory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<int>("BloodDonationType")
                        .HasColumnType("integer")
                        .HasColumnName("BloodDonationType");

                    b.Property<int>("BloodGroup")
                        .HasColumnType("integer")
                        .HasColumnName("BloodGroup");

                    b.Property<Guid>("BloodTansfusionCenterId")
                        .HasColumnType("uuid")
                        .HasColumnName("BloodTansfusionCenterId");

                    b.Property<int?>("MaxQty")
                        .HasColumnType("integer")
                        .HasColumnName("MaxQty");

                    b.Property<int?>("MinQty")
                        .HasColumnType("integer")
                        .HasColumnName("MinQty");

                    b.Property<int?>("TotalQty")
                        .HasColumnType("integer")
                        .HasColumnName("TotalQty");

                    b.HasKey("Id");

                    b.HasIndex("BloodTansfusionCenterId");

                    b.ToTable("BloodInventories", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodTansfusionCenter", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("Address");

                    b.Property<string>("Contact")
                        .HasColumnType("text")
                        .HasColumnName("Contact");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("Tel")
                        .HasColumnType("text")
                        .HasColumnName("Tel");

                    b.Property<int>("WilayaId")
                        .HasColumnType("integer")
                        .HasColumnName("WilayaId");

                    b.HasKey("Id");

                    b.HasIndex("WilayaId");

                    b.ToTable("BloodTansfusionCenters", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.Commune", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<int>("WilayaId")
                        .HasColumnType("integer")
                        .HasColumnName("WilayaId");

                    b.HasKey("Id");

                    b.HasIndex("WilayaId");

                    b.ToTable("Communes", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.Contributors.Contributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Contributors");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.DonorBloodTransferCenterSubscriptions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("ApplicationUserId");

                    b.Property<Guid>("BloodTansfusionCenterId")
                        .HasColumnType("uuid")
                        .HasColumnName("BloodTansfusionCenterId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("BloodTansfusionCenterId");

                    b.ToTable("DonorBloodTransferCenterSubscriptions", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.Wilaya", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Wilayas", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.ApplicationUser", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.Commune", "Commune")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("CommuneId");

                    b.Navigation("Commune");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodDonationPledge", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("BloodDonationPledges")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD.PublicPortal.Core.Entities.BloodDonationRequest", "BloodDonationRequest")
                        .WithMany("BloodDonationPledges")
                        .HasForeignKey("BloodDonationRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("BloodDonationRequest");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodDonationRequest", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.BloodTansfusionCenter", "BloodTansfusionCenter")
                        .WithMany("BloodDonationRequests")
                        .HasForeignKey("BloodTansfusionCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BloodTansfusionCenter");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodInventory", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.BloodTansfusionCenter", "BloodTansfusionCenter")
                        .WithMany("BloodInventories")
                        .HasForeignKey("BloodTansfusionCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BloodTansfusionCenter");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodTansfusionCenter", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.Wilaya", "Wilaya")
                        .WithMany("BloodTansfusionCenters")
                        .HasForeignKey("WilayaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Wilaya");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.Commune", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.Wilaya", "Wilaya")
                        .WithMany("Communes")
                        .HasForeignKey("WilayaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wilaya");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.Contributors.Contributor", b =>
                {
                    b.OwnsOne("BD.PublicPortal.Core.Entities.Contributors.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("ContributorId")
                                .HasColumnType("integer");

                            b1.Property<string>("CountryCode")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Extension")
                                .HasColumnType("text");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("ContributorId");

                            b1.ToTable("Contributors");

                            b1.WithOwner()
                                .HasForeignKey("ContributorId");
                        });

                    b.Navigation("PhoneNumber");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.DonorBloodTransferCenterSubscriptions", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("DonorBloodTransferCenterSubscriptions")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD.PublicPortal.Core.Entities.BloodTansfusionCenter", "BloodTansfusionCenter")
                        .WithMany("DonorBloodTransferCenterSubscriptions")
                        .HasForeignKey("BloodTansfusionCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("BloodTansfusionCenter");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD.PublicPortal.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("BD.PublicPortal.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.ApplicationUser", b =>
                {
                    b.Navigation("BloodDonationPledges");

                    b.Navigation("DonorBloodTransferCenterSubscriptions");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodDonationRequest", b =>
                {
                    b.Navigation("BloodDonationPledges");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.BloodTansfusionCenter", b =>
                {
                    b.Navigation("BloodDonationRequests");

                    b.Navigation("BloodInventories");

                    b.Navigation("DonorBloodTransferCenterSubscriptions");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.Commune", b =>
                {
                    b.Navigation("ApplicationUsers");
                });

            modelBuilder.Entity("BD.PublicPortal.Core.Entities.Wilaya", b =>
                {
                    b.Navigation("BloodTansfusionCenters");

                    b.Navigation("Communes");
                });
#pragma warning restore 612, 618
        }
    }
}
