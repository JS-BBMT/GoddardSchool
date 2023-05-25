using Microsoft.Extensions.DependencyInjection;
using FranchiseePortal.HealthChecks;

namespace FranchiseePortal.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<FranchiseePortalDbContextHealthCheck>("Database Connection");
            builder.AddCheck<FranchiseePortalDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");  

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
