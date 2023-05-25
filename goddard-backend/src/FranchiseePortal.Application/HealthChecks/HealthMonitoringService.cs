using Abp.Domain.Uow;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading.Tasks;

namespace FranchiseePortal.HealthChecks
{
    public class HealthMonitoringService : FranchiseePortalAppServiceBase, IHealthMonitoringService
    {
        private readonly HealthCheckService _healthCheckService;
        public HealthMonitoringService(HealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        /// <summary>
        /// Health check endpoint for the App service
        /// 
        /// Disabling unit of work since this is controlled/Complete inside the database health checkers
        /// https://aspnetboilerplate.com/Pages/Documents/Unit-Of-Work
        /// </summary>
        /// <returns></returns>
        [UnitOfWork(false, IsDisabled = true)]
        public async Task<HealthReport> GetHealthCheckReport()
        {
            var report = await _healthCheckService.CheckHealthAsync();
            return report;
        }
    }
}
