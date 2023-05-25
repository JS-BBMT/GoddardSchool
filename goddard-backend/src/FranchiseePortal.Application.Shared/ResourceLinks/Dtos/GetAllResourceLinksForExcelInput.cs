using Abp.Application.Services.Dto;
using System;

namespace FranchiseePortal.ResourceLinks.Dtos
{
    public class GetAllResourceLinksForExcelInput
    {
        public string Filter { get; set; }

        public string TextFilter { get; set; }

        public string UrlFilter { get; set; }

        public string IconFilter { get; set; }

    }
}