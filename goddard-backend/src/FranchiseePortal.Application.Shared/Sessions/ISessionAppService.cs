using System.Threading.Tasks;
using Abp.Application.Services;
using FranchiseePortal.Sessions.Dto;

namespace FranchiseePortal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
