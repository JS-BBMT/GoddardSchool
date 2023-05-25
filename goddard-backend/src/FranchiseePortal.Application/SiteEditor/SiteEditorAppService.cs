using Abp.Authorization;
using Abp.UI;
using FranchiseePortal.Common;
using FranchiseePortal.Common.Dto;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Model;
using FranchiseePortal.SiteEditor.Dto;
using FranchiseePortal.Url;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FranchiseePortal.SiteEditor
{
    public class SiteEditorAppService : FranchiseePortalAppServiceBase, ISiteEditorAppService
    {
        private readonly ISchoolsApi _schoolsContentApi;
        private readonly IComponentsApi _componentsApi;
        private readonly SchoolUrlFactory _urlScrapeFactory;

        public SiteEditorAppService(
            SchoolUrlFactory urlScrapeFactory,
            ISchoolsApi schoolsContentApi,
            IComponentsApi componentsApi)
        {
            _urlScrapeFactory = urlScrapeFactory;
            _schoolsContentApi = schoolsContentApi;
            _componentsApi = componentsApi;
        }

        public async Task<GetSitePageOutput> GetSchoolSitePage(string crmId, GetSchoolSitePageInput input)
        {
            // Fetch school's page from Content API which fetches from Author instance
            var schoolPagePath = _urlScrapeFactory.GetSchoolPageScrapingPath(input);
            var json = await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPageGetAsync(crmId, schoolPagePath);

            var html = HtmlDocumentHelper.PreparePageForIframeRendering(json, _urlScrapeFactory.GetPageBaseUrl(input));

            return new GetSitePageOutput()
            {
                PageHTML = html
            };
        }

        public async Task<bool> ValidateSchoolPageExists(string schoolUrl)
        {
            var pageExists = false;
            if (string.IsNullOrEmpty(schoolUrl))
            {
                return false;
            }

            try
            {
                using (var webClient = new HttpClient())
                {
                    var result = (await webClient.GetAsync(schoolUrl)).EnsureSuccessStatusCode();

                    pageExists = result.IsSuccessStatusCode;
                }
            }
            catch (HttpRequestException ex)
            {
                Logger.Error(ex.Message, ex);
                if (ex.StatusCode != HttpStatusCode.NotFound)
                {
                    throw new UserFriendlyException(ex.Message, ex);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
                throw new UserFriendlyException(ex.Message, ex);
            }

            return pageExists;
        }

        public async Task UpdateHeroImage(string crmId, SaveHeroImageInput input)
        {

            if (!(await AuthorizeForSchoolAsync(crmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdUpdateSchoolPutAsync(crmId, new SchoolsUpdateRequest()
            {
                HeroImage = input.ContentPath
            });

            // Publish school to invalidate cache after updating hero image
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(crmId);
        }

        public async Task UpdateSchoolIconCards(string crmId, SaveIconCardsInput input)
        {
            if (!(await AuthorizeForSchoolAsync(crmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdUpdateSchoolPutAsync(crmId, new SchoolsUpdateRequest()
            {
                IconCardsJson = input.IconCardsJson
            });

            // Publish school to invalidate cache after updating selected Icon Cards
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(crmId);
        }

        public async Task UpdateSchoolImageCards(string crmId, string path, List<ImageCardUpdateDto> imageCards)
        {
            if (!(await AuthorizeForSchoolAsync(crmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            await _componentsApi.ApiV1DcpComponentsImageCardsPutAsync(path, imageCards);

            // Publish school to invalidate cache after updating selected Image Cards
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(crmId);
        }

        public async Task UpdateSchoolCustomText(string crmId, string path, TextComponentUpdateDto textComponentUpdateDto)
        {
            if (!(await AuthorizeForSchoolAsync(crmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            await _componentsApi.ApiV1DcpComponentsTextPutAsync(path, textComponentUpdateDto);

            // Publish school to invalidate cache after updating component
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(crmId);
        }

        public async Task UpdateSchoolCustomTitle(string crmId, string path, TitleComponentUpdateDto input)
        {
            if (!(await AuthorizeForSchoolAsync(crmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            await _componentsApi.ApiV1DcpComponentsTitlePutAsync(path, input);

            // Publish school to invalidate cache after updating component
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(crmId);
        }

        public async Task UpdateSchoolCarousel(string crmId, string path, List<CarouselItemDto> carouselItems)
        {
            if (!(await AuthorizeForSchoolAsync(crmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            await _componentsApi.ApiV1DcpComponentsCarouselPutAsync(path, carouselItems);

            // Publish school to invalidate cache after updating selected Carousel Images
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(crmId);
        }

    }
}
