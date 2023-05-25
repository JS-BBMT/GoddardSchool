using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FranchiseePortal.HealthChecks
{
    /// <summary>
    /// Service allow Health reporting endpoints discoverability for external monitors through the swagger.json
    /// https://dev.azure.com/GoddardSystemsIT/Franchisee%20Business%20Portal/_workitems/edit/13772
    /// </summary>
    public interface IHealthMonitoringService : IApplicationService
    {
        Task<HealthReport> GetHealthCheckReport();
    }
}
