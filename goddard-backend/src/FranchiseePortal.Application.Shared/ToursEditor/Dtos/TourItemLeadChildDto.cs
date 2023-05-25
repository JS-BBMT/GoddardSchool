using System;

namespace FranchiseePortal.ToursEditor.Dtos
{
    /// <summary>
    /// DTO for displaying lead child info for a tour item on a list or grid
    /// </summary>
    public class TourItemLeadChildDto
    {
        public DateTime DateOfBirth { get; set; }

        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
    }
}
