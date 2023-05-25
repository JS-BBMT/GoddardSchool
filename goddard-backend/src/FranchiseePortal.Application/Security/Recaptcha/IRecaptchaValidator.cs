using System.Threading.Tasks;

namespace FranchiseePortal.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}