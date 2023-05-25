using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}