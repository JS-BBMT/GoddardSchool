using FranchiseePortal.LeadsEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public class UpdateTourInput
    {
        public string SchoolId { get; set; }

        public DateTime ScheduledDateTime { get; set; }

        [Required]
        public string GuideId { get; set; }

        public string ClassRoom { get; set; } = string.Empty;

        [Required]
        public TourStatus Status { get; set; } = TourStatus.Scheduled;

        public string Notes { get; set; } = string.Empty;

        [Required]
        public UpdateLeadInput Lead { get; set; }

        public static void UpdateTourFields(UpdateTourInput input, TourDto tour)
        {
            tour.GuideId = input.GuideId;
            tour.ClassRoom = input.ClassRoom;
            tour.Status = input.Status;
            tour.Notes = input.Notes;
            tour.ScheduledDateTime = input.ScheduledDateTime;
        }
    }
}
