using FranchiseePortal.Common;
using FranchiseePortal.Common.Dto;
using FranchiseePortal.Configuration;
using FranchiseePortal.ContentWebApiClient.Api;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace FranchiseePortal.SiteMarketingToolEditor
{
    public class SiteMarketingToolEditorService : FranchiseePortalAppServiceBase, ISiteMarketingToolEditorService
    {
        private const string baseSiteMarketingToolPath = "/content/smt/us/en/";
        private readonly ISiteMarketingToolApi _siteMarketingToolApi;
        IConfigurationRoot _appConfiguration;

        public SiteMarketingToolEditorService(ISiteMarketingToolApi siteMarketingToolApi,
            IAppConfigurationAccessor appConfigurationAccessor)
        {
            _siteMarketingToolApi = siteMarketingToolApi;
            _appConfiguration = appConfigurationAccessor.Configuration;
        }

        public async Task<GetSitePageOutput> GetMarketingTool(string pageName)
        {
            string html = string.Empty;
            try
            {
                var json = await _siteMarketingToolApi.ApiV1DcpSitemarketingtoolGetAsync(baseSiteMarketingToolPath, pageName);

                html = HtmlDocumentHelper.PreparePageForIframeRendering(json, _appConfiguration["App:PageBaseUrl"]);                
            }
            catch (ContentWebApiClient.Client.ApiException ex)
            {
                if (ex.ErrorCode != (int)System.Net.HttpStatusCode.NotFound)
                {
                    throw;
                }                
            }

            return new GetSitePageOutput()
            {
                PageHTML = html
            };
        }
    }
}
