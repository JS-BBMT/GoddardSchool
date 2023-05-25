using System.Threading.Tasks;
using Abp.Application.Services;
using FranchiseePortal.Editions.Dto;
using FranchiseePortal.MultiTenancy.Dto;

namespace FranchiseePortal.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}