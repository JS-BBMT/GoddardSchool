using Abp.Authorization;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranchiseePortal.SummerCamp
{
    public class SummerCampEditorService : FranchiseePortalAppServiceBase, ISummerCampEditorService
    {
        #region Variables
        private readonly IComponentsApi _componentsApi;
        private readonly ISchoolsApi _schoolsContentApi;
        #endregion

        //========================================================================================

        #region Constructors
        public SummerCampEditorService(
           IComponentsApi componentsApi,
           ISchoolsApi schoolsContentApi)
        {
            _componentsApi = componentsApi;
            _schoolsContentApi = schoolsContentApi;
        }
        #endregion

        //========================================================================================

        #region Public Endpoints
        public async Task SaveSummerCampCalendar(string crmId, string path, AssetListDto data)
        {
            if (!(await AuthorizeForSchoolAsync(crmId)))
            {
                throw new AbpAuthorizationException(string.Format("User is not authorized to modify school"));
            }

            await _componentsApi.ApiV1DcpComponentsAssetListPutAsync(path, data);

            // Publish school to invalidate cache after updating selected SummerCamp Events
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(crmId);
        }
        #endregion
    }
}
