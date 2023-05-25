using System.Threading.Tasks;
using FranchiseePortal.Authorization.Users;

namespace FranchiseePortal.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
