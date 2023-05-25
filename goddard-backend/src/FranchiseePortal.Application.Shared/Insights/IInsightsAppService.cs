using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FranchiseePortal.Insights.Dtos;
using FranchiseePortal.Dto;

namespace FranchiseePortal.Insights
{
    public interface IInsightsAppService : IApplicationService
    {
        Task<PagedResultDto<GetInsightForViewDto>> GetAll(GetAllInsightsInput input);

        Task<GetInsightForViewDto> GetInsightForView(int id);

        Task<GetInsightForEditOutput> GetInsightForEdit(EntityDto input);

        Task CreateOrEdit(CreateOrEditInsightDto input);

        Task Delete(EntityDto input);

    }
}