using Abp.Runtime.Validation;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FranchiseePortal.SiteEditor.Dto
{
    public class GetSchoolSitePageInput : ICustomValidate
    {
        public static readonly string[] ValidPageIds = new string[] { Pages.Home, Pages.Faculty, Pages.SummerCamp };

        [Required]
        public string PageId { get; set; }

        public string CacheRefreshId { get; set; }

        public bool IsHomePage() 
        {
            return PageId.Equals(Pages.Home, StringComparison.OrdinalIgnoreCase);
        }

        public bool IsFacultyPage()
        {
            return PageId.Equals(Pages.Faculty, StringComparison.OrdinalIgnoreCase);
        }

        public bool IsSummerCampPage()
        {
            return PageId.Equals(Pages.SummerCamp, StringComparison.OrdinalIgnoreCase);
        }
        
        public void AddValidationErrors(CustomValidationContext context)
        {
            if (!ValidPageIds.Contains(PageId, StringComparer.OrdinalIgnoreCase))
            {
                var validIdsAsString = string.Join(", ", ValidPageIds.Select(x => $"'{x}'").ToArray());
                context.Results.Add(new ValidationResult($"{nameof(PageId)} is invalid.  Valid values are: {validIdsAsString}.",
                    new [] { nameof(PageId)}));
            }
        }
    }
}
