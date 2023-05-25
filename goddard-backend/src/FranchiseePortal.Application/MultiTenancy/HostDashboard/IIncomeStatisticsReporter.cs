using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FranchiseePortal.MultiTenancy.HostDashboard.Dto;

namespace FranchiseePortal.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}