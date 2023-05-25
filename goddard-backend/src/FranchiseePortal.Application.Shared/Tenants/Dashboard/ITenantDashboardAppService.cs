using Abp.Application.Services;
using FranchiseePortal.Insights.Dtos;
using FranchiseePortal.Tenants.Dashboard.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FranchiseePortal.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();

        GetDashboardDataOutput GetDashboardData(GetDashboardDataInput input);

        GetDailySalesOutput GetDailySales();

        GetProfitShareOutput GetProfitShare();

        GetSalesSummaryOutput GetSalesSummary(GetSalesSummaryInput input);

        GetTopStatsOutput GetTopStats();

        GetRegionalStatsOutput GetRegionalStats();

        GetGeneralStatsOutput GetGeneralStats();

        Task<GetInsightsOutput> GetAllInsights(GetAllInsightsInput input);
    }
}
