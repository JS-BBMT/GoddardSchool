using Abp.Authorization;
using System.Threading.Tasks;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;
using FranchiseePortal.AssetsEditor.Dtos;
using System.Linq;
using FranchiseePortal.ContentWebApiClient.Api;

namespace FranchiseePortal.AssetsEditor
{
    public partial class AssetsEditorService : FranchiseePortalAppServiceBase, IAssetsEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly IExtendedAssetsApi _assetsApi;
        private readonly SchoolsWebApiClient.Api.ISchoolsApi _schoolsApi;
        private readonly ISchoolsApi _schoolsContentApi;
        #endregion

        //========================================================================================

        #region Constructor
        public AssetsEditorService(IExtendedAssetsApi assetsApi, SchoolsWebApiClient.Api.ISchoolsApi schoolsApi, ISchoolsApi schoolsContentApi)
        {
            _assetsApi = assetsApi;
            _schoolsApi = schoolsApi;
            _schoolsContentApi = schoolsContentApi;
        }
        #endregion

        //========================================================================================

        public async Task<InitiateUploadResponse> InitiateUpload(InitiateUploadDto input)
        {
            if (!(await AuthorizeForSchoolAsync(input.CrmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            var response = _assetsApi.ApiV1DcpAssetsImageUploadLocationPostWithHttpInfo(input.Path, input.FileName, input.Size);

            var affinityId = response.Cookies.FirstOrDefault(x => x.Name.Equals("affinity"));

            response.Data.Affinity = affinityId.Value.Replace("%22", "");
            Logger.Info($"Affinity is {response.Data.Affinity}");
            return response.Data;
        }

        public async Task<CompleteUploadResponse> CompleteUpload(CompleteUploadDto input)
        {
            if (!(await AuthorizeForSchoolAsync(input.CrmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            var response = await _assetsApi.ApiV1DcpAssetsCompleteUploadGetWithHttpInfoAsync(input.CompleteUri, input.UploadToken, input.FileName, input.MimeType, input.Affinity, System.Threading.CancellationToken.None);

            await Task.Delay(3000);
            await _assetsApi.ApiV1DcpAssetsPublishPostAsync($"{input.Path}/{input.FileName}");

            return response.Data;
        }

        public async Task DeleteAsset(string crmId, string path, string filename)
        {
            if (!(await AuthorizeForSchoolAsync(crmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            await _assetsApi.ApiV1DcpAssetsDeleteDeleteAsync(path, filename);
        }
    }
}
