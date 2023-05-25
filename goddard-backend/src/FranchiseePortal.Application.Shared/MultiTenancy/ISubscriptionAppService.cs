using System.Threading.Tasks;
using Abp.Application.Services;

namespace FranchiseePortal.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
