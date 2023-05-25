using Abp.Authorization;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Model;
using System.Threading.Tasks;
using FranchiseePortal.SchoolsWebApiClient.Api;
using Abp.UI;
using System;

namespace FranchiseePortal.EventTemplatesEditor
{
    public class EventTemplatesEditorService : FranchiseePortalAppServiceBase, IEventTemplatesEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly IEventTemplatesApi _client;
        private readonly ISchoolsApi _schoolsApi;
        private const string UNIQUE_CONSTRAINT_ERROR_MESSAGE = "Cannot insert duplicate key row in object";
        #endregion

        //========================================================================================

        #region Constructor
        public EventTemplatesEditorService(IEventTemplatesApi client, ISchoolsApi schoolsApi)
        {
            _client = client;
            _schoolsApi = schoolsApi;
        }
        #endregion

        //========================================================================================

        #region public Endpoints

        public async Task<EventTemplate> CreateEventTemplate(PostEventTemplate eventTemplate)
        {
            // Need to get crmId from the fmsId that we're going to post to
            var school = _schoolsApi.ApiV1SchoolsFmsIdIdGet(eventTemplate.SchoolID.ToString());

            if (!await AuthorizeForSchoolAsync(school.CrmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            try
            {
                return await _client.ApiV1EventTemplatePostAsync(eventTemplate);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains(UNIQUE_CONSTRAINT_ERROR_MESSAGE, StringComparison.InvariantCultureIgnoreCase))
                {
                    throw new UserFriendlyException(400, L("EventTemplateExistsErrorMessage"));
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<EventTemplate> UpdateEventTemplate(long templateId, PostEventTemplate eventTemplate)
        {
            // Need to get crmId from the fmsId that we're going to post to
            var school = _schoolsApi.ApiV1SchoolsFmsIdIdGet(eventTemplate.SchoolID.ToString());

            if (!await AuthorizeForSchoolAsync(school.CrmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            return await _client.ApiV1EventTemplatePutAsync(templateId, eventTemplate);
        }

        public async Task DeleteEventTemplate(string crmId, long templateId)
        {
            if (!await AuthorizeForSchoolAsync(crmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            await _client.ApiV1EventTemplateDeleteAsync(templateId);
        }

        #endregion
    }
}
