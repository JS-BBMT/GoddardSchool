using FranchiseePortal.Dto;
using FranchiseePortal.LeadsEditor.Dtos;
using FranchiseePortal.LeadsWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FranchiseePortal.LeadsEditor
{
    public interface ILeadsEditorService
    {
        Task<List<LeadDto>> Find(FindLeadsInput input, PagingParametersDto paging);

        Task<LeadDto> FindLeadById(string crmId, string id);

        Task<LeadDto> CreateLead(ApiV1SchoolLeadsInternalPostRequest lead, bool? async = true);
    }
}
