using FranchiseePortal.Common.Dto;
using System.Threading.Tasks;

namespace FranchiseePortal.SiteMarketingToolEditor
{
    public interface ISiteMarketingToolEditorService
    {
        Task<GetSitePageOutput> GetMarketingTool(string path);
    }
}
