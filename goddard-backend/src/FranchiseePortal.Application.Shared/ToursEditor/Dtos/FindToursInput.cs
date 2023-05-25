using FranchiseePortal.ToursWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public class FindToursInput
    {
        [Required]
        public string SchoolId { get; set; } = string.Empty;
        public TourStatus? Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TourType? Type { get; set; }
        public string GuideName { get; set; } = string.Empty;
        public string LeadName { get; set; }
        public int? ChildAge { get; set; }
        public DateTime? LeadStartDate { get; set; }
        public DateTime? LeadEndDate { get; set; }
        public List<string> ProgramsOfInterest { get; set; }

        public bool HasAdvancedLeadFilters()
        {
            return !string.IsNullOrEmpty(LeadName) ||
                ChildAge.HasValue ||
                LeadStartDate.HasValue ||
                LeadEndDate.HasValue ||
                (ProgramsOfInterest != null && ProgramsOfInterest.Any());
        }
    }
}
