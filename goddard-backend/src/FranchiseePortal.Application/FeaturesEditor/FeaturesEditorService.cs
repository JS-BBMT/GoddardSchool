using Abp.Authorization;
using Abp.UI;
using FranchiseePortal.Common.Extensions;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FranchiseePortal.FeaturesEditor
{
    public class FeaturesEditorService : FranchiseePortalAppServiceBase, IFeaturesEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly IFeaturesApi _client;
        private readonly ISchoolsApi _schoolsContentApi;
        private readonly SchoolsWebApiClient.Api.ISchoolsApi _schoolsApi;
        #endregion

    //========================================================================================

    #region Constructor
    public FeaturesEditorService(IFeaturesApi client, ISchoolsApi schoolsContentApi, SchoolsWebApiClient.Api.ISchoolsApi schoolsApi)
        {
            _client = client;
            _schoolsContentApi = schoolsContentApi;
            _schoolsApi = schoolsApi;
        }
        #endregion

        //========================================================================================

        #region public Endpoints
        public List<Feature> GetAllFeatures()
        {
            return _client.ApiV1FeaturesGet();
        }
        public async Task<List<SchoolFeature>> GetSchoolFeatures(List<string> crmSchoolIds = default(List<string>), List<string> features = default(List<string>))
        {
            foreach (var schoolId in crmSchoolIds)
            {
                if (!(await AuthorizeForSchoolAsync(schoolId)))
                {
                    throw new AbpAuthorizationException(L("UnAuthorizedOperation"));
                }
            }

            return _client.ApiV1SchoolFeaturesGet(crmSchoolIds, features);
        }

        public async Task SaveSchoolFeatures(string crmId, List<string> alternateIds)
        {
            if (!await AuthorizeForSchoolAsync(crmId))
            {
                throw new AbpAuthorizationException(L("UnAuthorizedOperation"));
            }

            await SyncFeatures(crmId, alternateIds);

            // Clear the school api cache of current features
            await _schoolsApi.ApiV1SchoolsIdClearFeaturesCachePostAsync(crmId);
            // Publish the school via the content API to invalidate the cache
            await _schoolsContentApi.ApiV1DcpSchoolsCrmIdPublishPostAsync(crmId);
        }

        private async Task SyncFeatures(string crmId, List<string> alternateIds) {
            var newFeatures = alternateIds.EmptyIfNull();

            //Get the shool features to delete the features that was not passed in
            var schoolFeatures = await GetSchoolFeatures(new List<string>() { crmId });

            //Remove all features that the school already has
            if (schoolFeatures != null && schoolFeatures.Any()) {
                newFeatures = alternateIds.EmptyIfNull().Where(x => !schoolFeatures.Any(y => y.AlternateId.Equals(x))).ToList();

                //Find the features that where previously selected but now should be deleted
                var featuresToDelete = schoolFeatures.Where(x => !alternateIds.Any(y => x.AlternateId.Equals(y)));

                //Delete not selected features from shool
                await Task.WhenAll(featuresToDelete.Select(s =>
                    _client.ApiV1SchoolFeaturesSchoolCrmIdDeleteAsync(crmId, new DeleteSchoolFeatureModel(s.AlternateId))));
            }

            //Add all selected features to school
            await Task.WhenAll(newFeatures.Select(s =>
                _client.ApiV1SchoolFeaturesSchoolCrmIdPostAsync(crmId, new AddSchoolFeatureByAlternateIdModel(s))));
        }

        public void ThrowError()
        {
            throw new UserFriendlyException(500, L("ErrorSavingData"));
        }

        #endregion
    }
}
