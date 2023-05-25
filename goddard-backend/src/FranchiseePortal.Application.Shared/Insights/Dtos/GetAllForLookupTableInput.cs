using Abp.Application.Services.Dto;

namespace FranchiseePortal.Insights.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}