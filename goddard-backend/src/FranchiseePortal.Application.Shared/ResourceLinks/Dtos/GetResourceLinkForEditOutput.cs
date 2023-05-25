using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.ResourceLinks.Dtos
{
    public class GetResourceLinkForEditOutput
    {
        public CreateOrEditResourceLinkDto ResourceLink { get; set; }

    }
}