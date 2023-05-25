using HtmlAgilityPack;
using Newtonsoft.Json;
using System.Linq;

namespace FranchiseePortal.Common
{
    public static class HtmlDocumentHelper
    {
        public static string PreparePageForIframeRendering(string json, string href)
        {
            // API response is returned as JSON, convert back to string
            var html = JsonConvert.DeserializeObject<string>(json);

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            //Add document base element
            var head = htmlDoc.DocumentNode.SelectSingleNode("/html/head");

            // Add base tag that points to publish instance for assets
            var baseElement = htmlDoc.CreateElement("base");
            baseElement.SetAttributeValue("href", href);
            head.PrependChild(baseElement);

            //Some styles fixes                
            var style = htmlDoc.CreateElement("style");
            var text = htmlDoc.CreateTextNode(
                @".gsi-marker-border-mask-top { -webkit-mask-image: none !important; }
                    .cmp-experiencefragment--footer { -webkit-mask-image: none !important; }"
            );
            style.AppendChild(text);
            head.AppendChild(style);

            //Removing script tag for GA Analytics
            var scriptsToRemove = htmlDoc.DocumentNode.DescendantsAndSelf()
                .Where(x => x.Name == "script" && x.OuterHtml.Contains("launch-"))
                .ToList();

            if (scriptsToRemove.Any())
            {
                for (int i = 0; i < scriptsToRemove.Count(); i++)
                {
                    scriptsToRemove[i].Remove();
                }
            }

            return htmlDoc.DocumentNode.OuterHtml;
        }
    }
}
