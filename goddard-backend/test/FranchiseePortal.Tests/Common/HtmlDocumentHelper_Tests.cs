using FranchiseePortal.Common;
using Shouldly;
using Xunit;

namespace FranchiseePortal.Tests.Common
{
    public class HtmlDocumentHelper_Tests
    {
        [Fact]
        public void AddBaseTag_Test()
        {
            // Arrange
            var json = KnownHtmlPages.JSON_HomePage;
            var href = "https://www-stage.goddardschool.com/";

            // Act
            var output = HtmlDocumentHelper.PreparePageForIframeRendering(json, href);

            // Assert
            output.ShouldContain(@"<base href=""https://www-stage.goddardschool.com/"">");
        }
        
        [Fact]
        public void AddGSIStyleTag_Test()
        {
            // Arrange
            var json = KnownHtmlPages.JSON_HomePage;
            var href = "https://www-stage.goddardschool.com/";

            // Act
            var output = HtmlDocumentHelper.PreparePageForIframeRendering(json, href);

            // Assert
            output.ShouldContain(@"<style>.gsi-marker-border-mask-top { -webkit-mask-image: none !important; }
                    .cmp-experiencefragment--footer { -webkit-mask-image: none !important; }</style>");
        }
        
        [Fact]
        public void RemoveGoogleAnalyticScriptTags_Test()
        {
            // Arrange
            var json = KnownHtmlPages.JSON_HomePage;
            var href = "https://www-stage.goddardschool.com/";

            // Act
            var output = HtmlDocumentHelper.PreparePageForIframeRendering(json, href);

            // Assert
            output.ShouldNotContain(@"launch-");
        }
    }
}
