using Xunit;
using FranchiseePortal.SiteEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FranchiseePortal.Tests;
using FranchiseePortal.ContentWebApiClient.Api;
using Moq;
using FranchiseePortal.Configuration;
using FranchiseePortal.SiteEditor.Dto;
using System.Threading;
using Newtonsoft.Json;

namespace FranchiseePortal.SiteEditor.Tests
{
    public class SiteEditorAppServiceTests : AppTestBase
    {
        private SiteEditorAppService _sut;
        private Mock<ISchoolsApi> _schoolsApiMock;

        public SiteEditorAppServiceTests()
        {
            _schoolsApiMock = new Mock<ISchoolsApi>();
            _sut = new SiteEditorAppService(
                new Url.SchoolUrlFactory(LocalIocManager.Resolve<IAppConfigurationAccessor>()),
                _schoolsApiMock.Object,
                Mock.Of<IComponentsApi>());
        }

        [Fact()]
        public async Task GetSchoolSitePage_ReturnsPageFromSchoolsContentApi()
        {
            // Arrange
            var crmId = Guid.NewGuid().ToString();

            _schoolsApiMock
                .Setup(x => x.ApiV1DcpSchoolsCrmIdPageGetAsync(crmId, "/our-school/special-programs/summer-camp", 0, default(CancellationToken)))
                .ReturnsAsync(JsonConvert.SerializeObject("<html><head><title>SummerCamp</title></head><body>foobar</body></html>"));

            // Act
            var actual = await _sut.GetSchoolSitePage(
                crmId,
                new GetSchoolSitePageInput()
                {
                    PageId = Pages.SummerCamp
                });

            // Assert
            Assert.Contains("<title>SummerCamp</title>", actual.PageHTML);

        }
    }
}