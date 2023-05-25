using FranchiseePortal.EntityFrameworkCore;

namespace FranchiseePortal.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly FranchiseePortalDbContext _context;

        public InitialHostDbBuilder(FranchiseePortalDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            new DefaultResourceLinkCreator(_context).Create();            

            _context.SaveChanges();
        }
    }
}
