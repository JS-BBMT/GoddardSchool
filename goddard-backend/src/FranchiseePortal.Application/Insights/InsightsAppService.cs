using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using FranchiseePortal.Insights.Dtos;
using FranchiseePortal.Dto;
using Abp.Application.Services.Dto;
using FranchiseePortal.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using Abp.UI;
using FranchiseePortal.Storage;

namespace FranchiseePortal.Insights
{
    [AbpAuthorize(AppPermissions.Pages_Administration_Insights)]
    public class InsightsAppService : FranchiseePortalAppServiceBase, IInsightsAppService
    {
        private readonly IInsightsRepository _insightRepository;

        public InsightsAppService(IInsightsRepository insightRepository)
        {
            _insightRepository = insightRepository;

        }

        public async Task<PagedResultDto<GetInsightForViewDto>> GetAll(GetAllInsightsInput input)
        {

            var filteredInsights = _insightRepository.GetAll()
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.Header.Contains(input.Filter) || e.Body.Contains(input.Filter) || e.Url.Contains(input.Filter));

            var pagedAndFilteredInsights = filteredInsights
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

            var insights = from o in pagedAndFilteredInsights
                           select new
                           {
                               o.Header,
                               o.Body,
                               Id = o.Id,
                               Url = o.Url,
                               CreationTime = o.CreationTime,
                               SortOrder = o.SortOrder
                           };

            var totalCount = await filteredInsights.CountAsync();

            var dbList = await insights.ToListAsync();
            var results = new List<GetInsightForViewDto>();

            foreach (var o in dbList)
            {
                var res = new GetInsightForViewDto()
                {
                    Insight = new InsightDto
                    {

                        Header = o.Header,
                        Body = o.Body,
                        Id = o.Id,
                        Url = o.Url,
                        CreationTime = o.CreationTime,
                        SortOrder = o.SortOrder
                    }
                };

                results.Add(res);
            }

            return new PagedResultDto<GetInsightForViewDto>(
                totalCount,
                results
            );

        }

        public async Task<GetInsightForViewDto> GetInsightForView(int id)
        {
            var insight = await _insightRepository.GetAsync(id);

            var output = new GetInsightForViewDto { Insight = ObjectMapper.Map<InsightDto>(insight) };

            return output;
        }

        [AbpAuthorize(AppPermissions.Pages_Administration_Insights_Edit)]
        public async Task<GetInsightForEditOutput> GetInsightForEdit(EntityDto input)
        {
            var insight = await _insightRepository.FirstOrDefaultAsync(input.Id);

            var output = new GetInsightForEditOutput { Insight = ObjectMapper.Map<CreateOrEditInsightDto>(insight) };

            return output;
        }

        public async Task CreateOrEdit(CreateOrEditInsightDto input)
        {
            if (input.Id == null)
            {
                await Create(input);
            }
            else
            {
                await Update(input);
            }
        }

        [AbpAuthorize(AppPermissions.Pages_Administration_Insights_Create)]
        protected virtual async Task Create(CreateOrEditInsightDto input)
        {
            var insight = ObjectMapper.Map<Insight>(input);

            //Place new Insights & Updates to the top of list when user does not set the order
            insight.SortOrder = input.SortOrder ?? 0;

            insight = await _insightRepository.InsertAsync(insight);

            //reorder 
            await Reorder(insight);
        }

        [AbpAuthorize(AppPermissions.Pages_Administration_Insights_Edit)]
        protected virtual async Task Update(CreateOrEditInsightDto input)
        {
            var insight = await _insightRepository.FirstOrDefaultAsync((int)input.Id);
            var reorder = insight.SortOrder != input.SortOrder;

            ObjectMapper.Map(input, insight);

            if (reorder)
            {
                await Reorder(insight);
            }
        }

        [AbpAuthorize(AppPermissions.Pages_Administration_Insights_Delete)]
        public async Task Delete(EntityDto input)
        {
            await _insightRepository.DeleteAsync(input.Id);
        }

        private async Task Reorder(Insight insight)
        {
            insight.SortOrder = NormalizeSortOrder(insight.SortOrder.GetValueOrDefault());
            insight.LastModifierUserId = AbpSession.UserId;
            insight.LastModificationTime = DateTime.Now;
            await _insightRepository.UpdateSortOrder(insight);
        }

        /// <summary>
        /// Ensure sort order is a valid ordinal number for the range of insights
        /// </summary>
        /// <param name="sortOrder"></param>
        private int NormalizeSortOrder(int sortOrder)
        {
            var currentInsights = _insightRepository.Count();
            if (sortOrder < 0)
                return 0;

            if (sortOrder > currentInsights)
                return currentInsights;

            return sortOrder;
        }
    }
}