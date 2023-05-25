using System.Collections.Generic;
using System.Linq;
using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using FranchiseePortal.EntityFrameworkCore;
using FranchiseePortal.ResourceLinks;

namespace FranchiseePortal.Migrations.Seed.Host
{
    public class DefaultResourceLinkCreator
    {
        public static List<ResourceLink> InitialLanguages => GetInitialResourceLinks();

        private readonly FranchiseePortalDbContext _context;

        private static List<ResourceLink> GetInitialResourceLinks()
        {
            var tenantId = FranchiseePortalConsts.MultiTenancyEnabled ? null : (int?)1;
            return new List<ResourceLink>
            {
                new ResourceLink(){ Text= "School Site Editor", Icon ="Color-Computer", Url = "/app/site-editor/edit-home-page", IsExternal = false }
            };
        }

        public DefaultResourceLinkCreator(FranchiseePortalDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateResourceLinks();
        }

        private void CreateResourceLinks()
        {
            foreach (var link in InitialLanguages)
            {
                AddLanguageIfNotExists(link);
            }
        }

        private void AddLanguageIfNotExists(ResourceLink link)
        {
            if (_context.ResourceLinks.IgnoreQueryFilters().Any(l => l.Text == link.Text))
            {
                return;
            }

            _context.ResourceLinks.Add(link);

            _context.SaveChanges();
        }
    }
}
