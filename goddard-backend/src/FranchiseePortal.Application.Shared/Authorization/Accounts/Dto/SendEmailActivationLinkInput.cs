using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}