using Abp.Application.Services;
using FranchiseePortal.CareersWebApiClient.Model;
using System.Threading.Tasks;

namespace FranchiseePortal.CareersEditor
{
    public interface ICareersEditorService : IApplicationService
    {
        Task<Career> SaveCareer(Career career);
        Task<Career> DeleteCareer(long careerId);
    }
}
