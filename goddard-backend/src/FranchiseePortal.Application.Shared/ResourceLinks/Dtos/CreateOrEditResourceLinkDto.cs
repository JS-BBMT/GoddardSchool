using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.ResourceLinks.Dtos
{
    public class CreateOrEditResourceLinkDto : EntityDto<int?>
    {

        [Required]
        public string Text { get; set; }

        [Required]
        public string Url { get; set; }

        public string Icon { get; set; }

        public bool IsExternal { get; set; }
    }
}