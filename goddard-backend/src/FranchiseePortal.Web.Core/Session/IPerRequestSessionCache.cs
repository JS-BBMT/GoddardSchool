using System.Threading.Tasks;
using FranchiseePortal.Sessions.Dto;

namespace FranchiseePortal.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
