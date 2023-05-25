using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using FranchiseePortal.EntityFrameworkCore;

namespace FranchiseePortal.HealthChecks
{
    public class FranchiseePortalDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public FranchiseePortalDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("FranchiseePortalDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("FranchiseePortalDbContext could not connect to database"));
        }
    }
}
