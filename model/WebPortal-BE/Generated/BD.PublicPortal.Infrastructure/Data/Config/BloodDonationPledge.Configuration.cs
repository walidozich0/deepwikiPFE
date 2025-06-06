﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 24-05-2025 09:37:07
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

namespace BD.PublicPortal.Core
{
    /// <summary>
    /// There are no comments for BloodDonationPledgeConfiguration in the schema.
    /// </summary>
    public partial class BloodDonationPledgeConfiguration : IEntityTypeConfiguration<BloodDonationPledge>
    {
        /// <summary>
        /// There are no comments for Configure(EntityTypeBuilder<BloodDonationPledge> builder) method in the schema.
        /// </summary>
        public void Configure(EntityTypeBuilder<BloodDonationPledge> builder)
        {
            builder.ToTable(@"BloodDonationPledges");
            builder.Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.EvolutionStatus).HasColumnName(@"EvolutionStatus").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PledgeInitiatedDate).HasColumnName(@"PledgeInitiatedDate").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PledgeDate).HasColumnName(@"PledgeDate").ValueGeneratedNever();
            builder.Property(x => x.PledgeHonoredOrCanceledDate).HasColumnName(@"PledgeHonoredOrCanceledDate").ValueGeneratedNever();
            builder.Property(x => x.PledgeNotes).HasColumnName(@"PledgeNotes").ValueGeneratedNever();
            builder.Property(x => x.CantBeDoneReason).HasColumnName(@"CantBeDoneReason").ValueGeneratedNever();
            builder.Property(x => x.BloodDonationRequestId).HasColumnName(@"BloodDonationRequestId").ValueGeneratedNever();
            builder.Property(x => x.ApplicationUserId).HasColumnName(@"ApplicationUserId").ValueGeneratedNever();
            builder.HasKey(@"Id");
            builder.HasOne(x => x.BloodDonationRequest).WithMany(op => op.BloodDonationPledges).HasForeignKey(@"BloodDonationRequestId").IsRequired(true);
            builder.HasOne(x => x.ApplicationUser).WithMany(op => op.BloodDonationPledges).HasForeignKey(@"ApplicationUserId").IsRequired(true);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<BloodDonationPledge> builder);

        #endregion
    }

}
