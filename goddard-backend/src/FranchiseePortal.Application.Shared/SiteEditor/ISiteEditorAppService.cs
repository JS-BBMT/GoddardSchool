using Abp.Application.Services;
using FranchiseePortal.Common.Dto;
using FranchiseePortal.ContentWebApiClient.Model;
using FranchiseePortal.SiteEditor.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FranchiseePortal.SiteEditor
{
    public interface ISiteEditorAppService : IApplicationService
    {
        Task<GetSitePageOutput> GetSchoolSitePage(string crmId, GetSchoolSitePageInput input);
        Task<bool> ValidateSchoolPageExists(string schoolUrl);
        Task UpdateHeroImage(string crmId, SaveHeroImageInput input);
        Task UpdateSchoolIconCards(string crmId, SaveIconCardsInput input);
        Task UpdateSchoolImageCards(string crmId, string path, List<ImageCardUpdateDto> imageCards);
        Task UpdateSchoolCustomText(string crmId, string path, TextComponentUpdateDto textComponentUpdateDto);
    }
}
