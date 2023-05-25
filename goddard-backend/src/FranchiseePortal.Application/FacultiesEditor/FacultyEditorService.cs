using Abp.Authorization;
using FranchiseePortal.Authorization;
using FranchiseePortal.FacultiesWebApiClient.Api;
using FranchiseePortal.FacultiesWebApiClient.Model;
using System.Linq;
using System.Threading.Tasks;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.FacultyEditor;
using System.Collections.Generic;
using Abp.UI;

namespace FranchiseePortal.FacultiesEditor
{
    public class FacultyEditorService : FranchiseePortalAppServiceBase, IFacultyEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly IFacultyBiosApi _client;
        private readonly SchoolsWebApiClient.Api.ISchoolsApi _schoolsApi;
        private readonly IAssetsApi _assetsApi;
        private readonly ISchoolsApi _schoolsContentApi;

        #endregion

        //========================================================================================

        #region Constructor
        public FacultyEditorService(IFacultyBiosApi client, SchoolsWebApiClient.Api.ISchoolsApi schoolsApi, ISchoolsApi schoolsContentApi, IAssetsApi assetsApi) {
            _client = client;
            _schoolsApi = schoolsApi;
            _schoolsContentApi = schoolsContentApi;
            _assetsApi = assetsApi;
        }
        #endregion

        //========================================================================================
        
        #region public Endpoints
        public async Task SaveFaculty(List<PostFacultyBiosRequest> postFacultyBiosRequest) 
        {
            long fmsSchoolId = postFacultyBiosRequest.First().FmsSchoolId;

            if (postFacultyBiosRequest.Any(s=> s.FmsSchoolId != fmsSchoolId))
            {
                throw new UserFriendlyException("Invalid fmsSchoolId", "User Cannot modify faculty members from diffent Schools in the same request");
            }

            var school = _schoolsApi.ApiV1SchoolsFmsIdIdGet(fmsSchoolId.ToString());

            if (!await AuthorizeForSchoolAsync(school.CrmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            await _client.ApiV1PostfacultiesPostAsync(postFacultyBiosRequest);

            // Publish the school via the content API to invalidate the cache
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(school.CrmId);
        }

        public async Task DeleteFacultyImage(long fmsSchoolId, string filename) {

            var school = _schoolsApi.ApiV1SchoolsFmsIdIdGet(fmsSchoolId.ToString());

            if (!await AuthorizeForSchoolAsync(school.CrmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var contentSchool = await _schoolsContentApi.ApiV1DcpSchoolsGetAsync(school.CrmId);

            await _assetsApi.ApiV1DcpAssetsDeleteDeleteAsync(contentSchool.FacultyDamPath, filename);
        }

        #endregion
    }
}
