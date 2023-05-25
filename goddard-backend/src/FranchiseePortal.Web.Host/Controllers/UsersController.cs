using Abp.AspNetCore.Mvc.Authorization;
using FranchiseePortal.Authorization;
using FranchiseePortal.Storage;
using Abp.BackgroundJobs;

namespace FranchiseePortal.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}