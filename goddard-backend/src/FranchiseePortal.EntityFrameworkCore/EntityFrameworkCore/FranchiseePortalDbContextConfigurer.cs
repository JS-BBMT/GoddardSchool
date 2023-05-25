using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FranchiseePortal.EntityFrameworkCore
{
    public static class FranchiseePortalDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FranchiseePortalDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FranchiseePortalDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}