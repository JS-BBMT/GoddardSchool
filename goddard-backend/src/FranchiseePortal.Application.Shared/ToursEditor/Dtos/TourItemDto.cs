using FranchiseePortal.ToursWebApiClient.Model;
using System;

namespace FranchiseePortal.ToursEditor.Dtos
{
    /// <summary>
    /// DTO for displaying tour info in a item on a list or grid
    /// </summary>
    public class TourItemDto
    {
        public string Id { get; set; }

        public string ClassRoom { get; set; }

        public string Notes { get; set; }

        public TourGuideDto Guide { get; set; }

        public TourItemLeadDto Lead { get; set; }

        public DateTime ScheduledDateTime { get; set; }

        public TourStatus Status { get; set; }

        public TourType Type { get; set; }
        
        public FollowUpTimeFrame? FollowUpTimeFrame { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
