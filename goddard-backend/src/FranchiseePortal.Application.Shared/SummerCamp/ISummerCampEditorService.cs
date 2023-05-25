using Abp.Application.Services;
using FranchiseePortal.ContentWebApiClient.Model;
using System.Threading.Tasks;

namespace FranchiseePortal.SummerCamp
{
    public interface ISummerCampEditorService : IApplicationService
    {
        Task SaveSummerCampCalendar(string crmId, string path, AssetListDto data);
    }
}
