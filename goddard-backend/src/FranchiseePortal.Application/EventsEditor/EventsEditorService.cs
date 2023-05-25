using Abp.Authorization;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Model;
using System.Threading.Tasks;
using FranchiseePortal.SchoolsWebApiClient.Api;

namespace FranchiseePortal.EventsEditor
{
    public class EventsEditorService: FranchiseePortalAppServiceBase, IEventsEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly IEventsApi _client;
        private readonly ISchoolsApi _schoolsApi;

        #endregion

        //========================================================================================

        #region Constructor
        public EventsEditorService(IEventsApi client, ISchoolsApi schoolsApi) {
            _client = client;
            _schoolsApi = schoolsApi;
        }
        #endregion

        //========================================================================================

        #region public Endpoints

        public async Task<PostEvents> SaveEvent(PostEvents postEvents)
        {
            // Need to get crmId from the fmsId that we're going to post to
            var school = _schoolsApi.ApiV1SchoolsFmsIdIdGet(postEvents.FmsSchoolId.ToString());

            if (!await AuthorizeForSchoolAsync(school.CrmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }


            return await _client.ApiV1AddEventsPostAsync(postEvents);
        }

        #endregion
    }
    
}
