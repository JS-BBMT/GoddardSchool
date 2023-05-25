using FranchiseePortal.LeadsWebApiClient.Model;
using System;

namespace FranchiseePortal.ToursEditor.Dtos
{
    /// <summary>
    /// DTO for displaying lead info for a tour item on a list or grid
    /// </summary>
    public class TourItemLeadDto
    {
        public long? SchoolParentLeadId { get; set; }

        public Guid GuidId { get; set; }

        public TourItemLeadChildDto[] SchoolChildLeads { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public LevelOfInterest? LevelOfInterest { get; set; }

        public string MobilePhone { get; set; }

        public string EmailAddress { get; set; }

        public string TourQuestions { get; set; }
    }
}
