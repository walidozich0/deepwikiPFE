﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 22-05-2025 15:16:13
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BD.BloodTransfusionCenter.Core
{
    /// <summary>
    /// There are no comments for DonorConfiguration in the schema.
    /// </summary>
    public partial class DonorConfiguration : IEntityTypeConfiguration<Donor>
    {
        /// <summary>
        /// There are no comments for Configure(EntityTypeBuilder<Donor> builder) method in the schema.
        /// </summary>
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder.ToTable(@"Donors");
            builder.Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName(@"Name").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.BirthDate).HasColumnName(@"BirthDate").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.NIN).HasColumnName(@"NIN").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Tel).HasColumnName(@"Tel").ValueGeneratedNever();
            builder.Property(x => x.Email).HasColumnName(@"Email").ValueGeneratedNever();
            builder.Property(x => x.NotesForBTC).HasColumnName(@"NotesForBTC").ValueGeneratedNever();
            builder.Property(x => x.LastDonationDate).HasColumnName(@"LastDonationDate").ValueGeneratedNever();
            builder.Property(x => x.CommuneId).HasColumnName(@"CommuneId").ValueGeneratedNever();
            builder.HasKey(@"Id");
            builder.HasMany(x => x.BloodDonations).WithOne(op => op.Donor).OnDelete(DeleteBehavior.Restrict).HasForeignKey(@"DonorId").IsRequired(true);
            builder.HasOne(x => x.Commune).WithMany(op => op.Donors).OnDelete(DeleteBehavior.Restrict).HasForeignKey(@"CommuneId").IsRequired(true);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<Donor> builder);

        #endregion
    }

}
