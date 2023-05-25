using System.Threading.Tasks;
using Abp.Application.Services;
using FranchiseePortal.Configuration.Host.Dto;

namespace FranchiseePortal.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
