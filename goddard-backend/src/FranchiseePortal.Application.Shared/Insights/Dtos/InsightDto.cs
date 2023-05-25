using System;
using Abp.Application.Services.Dto;

namespace FranchiseePortal.Insights.Dtos
{
    public class InsightDto : EntityDto
    {
        public string Header { get; set; }

        public string Body { get; set; }
        public string Url { get; set; }
        public DateTime CreationTime { get; set; }
        public int? SortOrder { get; set; }
    }
}