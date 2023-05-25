using FranchiseePortal.LeadsWebApiClient.Model;
using FranchiseePortal.LeadsWebApiClient.Api;
using System.Threading.Tasks;
using Abp.Authorization;
using FranchiseePortal.SchoolsWebApiClient.Api;
using System.Collections.Generic;
using FranchiseePortal.Dto;
using FranchiseePortal.LeadsEditor.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FranchiseePortal.LeadsEditor
{
    public class LeadsEditorService : FranchiseePortalAppServiceBase, ILeadsEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly ISchoolParentLeadsApi _schoolParentLeadClient;
        private readonly ISchoolsApi _schoolsApi;
        private const string APP_NAME = "iGoddard.com";
        #endregion

        //========================================================================================

        #region Constructor
        public LeadsEditorService(ISchoolParentLeadsApi client, ISchoolsApi schoolsApi)
        {
            _schoolParentLeadClient = client;
            _schoolsApi = schoolsApi;
        }
        #endregion

        //========================================================================================

        [HttpGet]
        public async Task<List<LeadDto>> Find(FindLeadsInput input, PagingParametersDto paging)
        {
            if (!await AuthorizeForSchoolAsync(input.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized for school");
            }

            var school = await _schoolsApi.ApiV1SchoolsIdGetAsync(input.SchoolId);

            var paged = await _schoolParentLeadClient.ApiV1SchoolLeadsGetAsync(
                schoolId: long.Parse(school.FmsId),
                q: input.Q,
                name: input.LeadName,
                input.ChildAge,
                input.StartDate,
                input.EndDate,
                input.ProgramsOfInterest,
                paging.Page,
                paging.PageSize);

            return paged.Items;
        }

        [HttpGet]
        public async Task<LeadDto> FindLeadById(string crmId, string id)
        {
            if (!await AuthorizeForSchoolAsync(crmId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            // Find lead
            var lead = await _schoolParentLeadClient.ApiV1SchoolLeadsIdGetAsync(id);

            return lead;
        }

        public async Task<LeadDto> CreateLead(ApiV1SchoolLeadsInternalPostRequest lead, bool? async = true)
        {
            var school = _schoolsApi.ApiV1SchoolsFmsIdIdGet(lead.SchoolId.ToString());

            if (!await AuthorizeForSchoolAsync(school.CrmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            return await _schoolParentLeadClient.ApiV1SchoolLeadsInternalPostAsync(async, APP_NAME, lead);
        }
    }
}
