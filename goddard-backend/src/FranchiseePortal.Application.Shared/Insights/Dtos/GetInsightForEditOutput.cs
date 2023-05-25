using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.Insights.Dtos
{
    public class GetInsightForEditOutput
    {
        public CreateOrEditInsightDto Insight { get; set; }

    }
}