using FranchiseePortal.ToursWebApiClient.Model;
using FranchiseePortal.LeadsWebApiClient.Model;
using System;
using System.ComponentModel.DataAnnotations;
using FranchiseePortal.LeadsEditor.Dtos;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public class CreateTourInput
    {
        [Required]
        public string SchoolId { get; set; }

        [Required]
        public DateTime ScheduledDateTime { get; set; }

        [Required]
        public string GuideId { get; set; }

        public string ClassRoom { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        [Required]
        public TourType Type { get; set; } = TourType.InPerson;

        [Required]
        public TourStatus Status { get; set; } = TourStatus.Scheduled;

        public FollowUpTimeFrame FollowUpTimeFrame { get; set; } = FollowUpTimeFrame.ASAP;

        [Required]
        public CreateLeadInput Lead { get; set; }

        public static TourDto CreateTourDto(CreateTourInput input)
        {
            return new TourDto(
                Guid.NewGuid().ToString(),
                input.Lead.SchoolParentLeadId.ToString(),
                input.Notes,
                input.ScheduledDateTime,
                DateTime.UtcNow,
                input.Type,
                input.SchoolId,
                input.Status,
                input.GuideId,
                null,
                input.ClassRoom,
                input.FollowUpTimeFrame);
        }
    }
}
