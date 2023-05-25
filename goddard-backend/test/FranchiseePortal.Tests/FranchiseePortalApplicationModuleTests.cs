using FranchiseePortal.AssetsEditor;
using Xunit;

namespace FranchiseePortal.Tests
{
    public class FranchiseePortalApplicationModuleTests : AppTestBase
    {
        [Fact()]
        public void RegisterApiClients_IExtendedAssetsApiBasePathCorrectlyConfigured()
        {
            // Arrange

            // Act
            var actual = LocalIocManager.Resolve<IExtendedAssetsApi>();

            // Assert
            // Verify that the default value isn't being used
            Assert.NotEqual("http://localhost", actual.Configuration.BasePath);
        }
    }
}