using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranchiseePortal.Insights
{
    public interface IInsightsRepository : IRepository<Insight, int>
    {
        Task<int> UpdateSortOrder(Insight insight);
    }
}
