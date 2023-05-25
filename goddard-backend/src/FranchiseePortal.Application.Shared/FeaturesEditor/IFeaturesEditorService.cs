using Abp.Application.Services;
using FranchiseePortal.FeaturesWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FranchiseePortal.FeaturesEditor
{
    public interface IFeaturesEditorService : IApplicationService
    {
        List<Feature> GetAllFeatures();
        Task<List<SchoolFeature>> GetSchoolFeatures(List<string> crmSchoolIds = default(List<string>), List<string> features = default(List<string>));
        Task SaveSchoolFeatures(string crmId, List<string> alternateIds);
    }
}
