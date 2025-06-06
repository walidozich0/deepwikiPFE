﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Data Transfer Object template.
// Code is generated on: 21-05-2025 19:15:12
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace BD.BloodTransfusionCenter.Core
{

    public partial class BloodOutOperationDTO
    {
        #region Constructors

        public BloodOutOperationDTO() {
        }

        public BloodOutOperationDTO(System.Guid id, BloodOutOperationType outOperationType, System.DateTime outDate, System.Guid bloodDonationId, BloodDonationDTO bloodDonation) {

          this.Id = id;
          this.OutOperationType = outOperationType;
          this.OutDate = outDate;
          this.BloodDonationId = bloodDonationId;
          this.BloodDonation = bloodDonation;
        }

        #endregion

        #region Properties

        public System.Guid Id { get; set; }

        public BloodOutOperationType OutOperationType { get; set; }

        public System.DateTime OutDate { get; set; }

        public System.Guid BloodDonationId { get; set; }

        #endregion

        #region Navigation Properties

        public BloodDonationDTO BloodDonation { get; set; }

        #endregion
    }

}
