using FranchiseePortal.Insights.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FranchiseePortal.Tenants.Dashboard.Dto
{
    public class GetInsightsOutput
    {
        public InsightDto[] Insights { get; set; }
    }
}
