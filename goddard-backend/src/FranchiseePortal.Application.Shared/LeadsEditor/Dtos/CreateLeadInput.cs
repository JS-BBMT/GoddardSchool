using FranchiseePortal.LeadsWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.LeadsEditor.Dtos
{
    public class CreateLeadInput
    {
        public long? SchoolParentLeadId { get; set; }

        public long SchoolId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } 

        [Required]
        [StringLength(50)]
        public string MobilePhone { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string ZipCode { get; set; }

        public ReferredBy? ReferredBy { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        [Range(1, 7)]
        public short? ContactPreference { get; set; }

        public string reCaptchaResponse { get; set; } 

        [Required]
        public List<CreateChildInput> SchoolChildLeads { get; set; } 

    }
}
