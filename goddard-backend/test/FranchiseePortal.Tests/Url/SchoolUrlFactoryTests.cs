using FranchiseePortal.SiteEditor.Dto;
using FranchiseePortal.Tests;
using Xunit;

namespace FranchiseePortal.Url.Tests
{
    public class SchoolUrlFactoryTests : AppTestBase
    {
        private readonly SchoolUrlFactory _sut;

        public SchoolUrlFactoryTests()
        {
            _sut = LocalIocManager.Resolve<SchoolUrlFactory>();
        }

        [Fact()]
        public void GetScrapingUrlTest()
        {
            // Arrange
            // 20220428RBP - Page sub-paths are copied from appSettings.json
            var expectedBase = $"";

            // Act
            // Assert
            TestGetScrapingUrlForPage(Pages.Home, $"{expectedBase}");
            TestGetScrapingUrlForPage(Pages.Faculty, $"{expectedBase}/our-teachers");
            TestGetScrapingUrlForPage(Pages.SummerCamp, $"{expectedBase}/our-school/special-programs/summer-camp");
        }

        private void TestGetScrapingUrlForPage(string pageId, string expected)
        {
            Assert.Equal(expected,
               _sut.GetSchoolPageScrapingPath(new GetSchoolSitePageInput() { PageId = pageId }));
        }
    }
}