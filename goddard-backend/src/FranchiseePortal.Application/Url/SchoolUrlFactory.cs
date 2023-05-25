using FranchiseePortal.Configuration;
using FranchiseePortal.SiteEditor.Dto;
using Microsoft.Extensions.Configuration;
using System;

namespace FranchiseePortal.Url
{
    public class SchoolUrlFactory
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolUrlFactory(IAppConfigurationAccessor appConfigurationAccessor)
        {
            _appConfiguration = appConfigurationAccessor.Configuration;
        }



        public string GetPageBaseUrl(GetSchoolSitePageInput input)
        {
            string pageURL = _appConfiguration["App:PageBaseUrl"];

            //check overrides for a specific module
            if (input.IsHomePage())
            {
                if (!string.IsNullOrEmpty(_appConfiguration["App:School:PageBaseUrl"]))
                {
                    pageURL = _appConfiguration["App:School:PageBaseUrl"];
                }
            }
            else if (input.IsFacultyPage())
            {
                if (!string.IsNullOrEmpty(_appConfiguration["App:Faculty:PageBaseUrl"]))
                {
                    pageURL = _appConfiguration["App:Faculty:PageBaseUrl"];
                }
            }

            return pageURL;
        }

        // This is the URL that we scrape the page from
        public string GetSchoolPageScrapingPath(GetSchoolSitePageInput input)
        {
            string pageConfigSection;

            // Get the page configuration section
            if (input.IsHomePage())
            {
                pageConfigSection = "App:School";
            }
            else if (input.IsFacultyPage())
            {
                pageConfigSection = "App:Faculty";
            }
            else if (input.IsSummerCampPage())
            {
                pageConfigSection = "App:SummerCamp";
            } 
            else
            {
                throw new ArgumentOutOfRangeException(nameof(input), input.PageId, "PageId is not a valid page ID.");
            }

            // Get the path for the page relative to the school's content path
            var result = _appConfiguration[$"{pageConfigSection}:PageContentPath"];

            return result;
        }
    }
}
