using Xunit;
using FranchiseePortal.SiteEditor.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Runtime.Validation;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.SiteEditor.Dto.Tests
{
    public class GetSchoolSitePageInputTests
    {
        [Fact()]
        public void AddValidationErrorsTest()
        {
            // Arrange
            var sut = new GetSchoolSitePageInput()
            {
                PageId = "foobar"
            };
            var results = new List<ValidationResult>();
            var context = new CustomValidationContext(results, null);

            // Act
            sut.AddValidationErrors(context);

            // Assert
            Assert.Equal($"PageId is invalid.  Valid values are: 'HomePage', 'FacultyPage', 'SummerCampPage'.", 
                results[0].ErrorMessage);
        }
    }
}