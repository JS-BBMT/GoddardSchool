using Abp.UI;
using FranchiseePortal.TestimonialsWebApiClient.Api;
using FranchiseePortal.TestimonialsWebApiClient.Model;
using System.Threading.Tasks;
using Abp.Authorization;
using FranchiseePortal.SchoolsWebApiClient.Api;

namespace FranchiseePortal.TestimonialsEditor
{
    public class TestimonialsEditorService : FranchiseePortalAppServiceBase, ITestimonialsEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly ITestimonialsApi _client;
        private readonly ISchoolsApi _schoolsApi;
        private readonly ContentWebApiClient.Api.ISchoolsApi _schoolsContentApi;

        #endregion

        //========================================================================================

        #region Constructor
        public TestimonialsEditorService(ITestimonialsApi client, ISchoolsApi schoolsApi, ContentWebApiClient.Api.ISchoolsApi schoolsContentApi) {
            _client = client;
            _schoolsApi = schoolsApi;
            _schoolsContentApi = schoolsContentApi;
        }
        #endregion

        //========================================================================================

        #region Public Endpoints
        public async Task<Testimonial> SaveTestimonial(TestimonialDto testimonialDto) {
            var school = _schoolsApi.ApiV1SchoolsFmsIdIdGet(testimonialDto.FmsSchoolId.ToString());

            if (!await AuthorizeForSchoolAsync(school.CrmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var testimonial = await _client.ApiV1AddtestimonialsPostAsync(testimonialDto);

            _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPost(school.CrmId);

            return testimonial;
        }

        public Task<Testimonial> ThrowError()
        {
            throw new UserFriendlyException(500, L("ErrorSavingData"));
        }

        #endregion
    }
}
