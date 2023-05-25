using System.Threading.Tasks;
using Abp.Application.Services;
using FranchiseePortal.Configuration.Tenants.Dto;

namespace FranchiseePortal.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
