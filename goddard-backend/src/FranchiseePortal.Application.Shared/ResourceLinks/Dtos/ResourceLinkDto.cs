using System;
using Abp.Application.Services.Dto;

namespace FranchiseePortal.ResourceLinks.Dtos
{
    public class ResourceLinkDto : EntityDto
    {
        public string Text { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }

        public bool IsExternal { get; set; }
    }
}