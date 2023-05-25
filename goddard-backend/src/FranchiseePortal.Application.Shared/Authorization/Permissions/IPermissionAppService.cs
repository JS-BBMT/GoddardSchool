using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FranchiseePortal.Authorization.Permissions.Dto;

namespace FranchiseePortal.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
