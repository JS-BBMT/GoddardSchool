using Abp.Application.Services.Dto;

namespace FranchiseePortal.ResourceLinks.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}