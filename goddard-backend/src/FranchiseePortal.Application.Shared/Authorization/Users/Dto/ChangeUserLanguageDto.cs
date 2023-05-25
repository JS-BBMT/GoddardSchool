using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
