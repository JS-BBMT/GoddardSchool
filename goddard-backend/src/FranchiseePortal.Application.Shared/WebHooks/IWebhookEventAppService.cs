using System.Threading.Tasks;
using Abp.Webhooks;

namespace FranchiseePortal.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
