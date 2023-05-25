using Abp.Application.Services.Dto;
using System;

namespace FranchiseePortal.Insights.Dtos
{
    public class GetAllInsightsInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }

    }
}