using System.Threading.Tasks;
using FranchiseePortal.Security.Recaptcha;

namespace FranchiseePortal.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
