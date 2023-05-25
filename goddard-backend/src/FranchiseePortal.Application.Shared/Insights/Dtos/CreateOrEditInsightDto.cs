using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.Insights.Dtos
{
    public class CreateOrEditInsightDto : EntityDto<int?>
    {

        [Required]
        public string Header { get; set; }

        [Required]
        public string Body { get; set; }

        public string Url { get; set; }
        public int? SortOrder { get; set; }
    }
}