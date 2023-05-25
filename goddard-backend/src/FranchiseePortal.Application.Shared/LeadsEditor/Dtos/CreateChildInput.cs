using System;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.LeadsEditor.Dtos
{
    public class CreateChildInput
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
