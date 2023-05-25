using System.Threading.Tasks;
using Abp.Application.Services;
using FranchiseePortal.MultiTenancy.Payments.Dto;
using FranchiseePortal.MultiTenancy.Payments.Stripe.Dto;

namespace FranchiseePortal.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}