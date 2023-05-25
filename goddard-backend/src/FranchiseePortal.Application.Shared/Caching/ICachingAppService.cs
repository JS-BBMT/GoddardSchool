using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FranchiseePortal.Caching.Dto;

namespace FranchiseePortal.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
