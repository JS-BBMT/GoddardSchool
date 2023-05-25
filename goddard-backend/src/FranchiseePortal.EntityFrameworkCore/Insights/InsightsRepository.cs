using System.Linq;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using FranchiseePortal.EntityFrameworkCore;
using FranchiseePortal.EntityFrameworkCore.Repositories;
using FranchiseePortal.Insights;
using System;
using Microsoft.Data.SqlClient;

namespace FranchiseePortal.EntityFrameworkCore.Insights
{
    public class InsightsRepository : FranchiseePortalRepositoryBase<Insight>, IInsightsRepository
    {
        public InsightsRepository(IDbContextProvider<FranchiseePortalDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public Task<int> UpdateSortOrder(Insight insight)
        {
            return GetDbContext().Database.ExecuteSqlRawAsync("EXEC [dbo].[usp_UpdateInsightSortOrder] @Id, @SortOrder, @LastModifierUserId, @LastModificationTime",
                parameters: new[] {
                        new SqlParameter("@Id", insight.Id),
                        new SqlParameter("@SortOrder", insight.SortOrder),
                        new SqlParameter("@LastModifierUserId", insight.LastModifierUserId),
                        new SqlParameter("@LastModificationTime", insight.LastModificationTime)
                    });
        }
    }
}
