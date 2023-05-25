using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace FranchiseePortal.Configuration
{
    public static class HostingEnvironmentExtensions
    {
        public static IConfigurationRoot GetAppConfiguration(this IWebHostEnvironment env)
        {
            // 20210512RBP - Expanded to add user secrets for other envs
            //return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsUserSecretsEnvironment());
        }

        /// <summary>
        /// Returns true for environments that should add user secrets
        /// </summary>
        /// <param name="env"></param>
        /// <returns></returns>
        public static bool IsUserSecretsEnvironment(this IWebHostEnvironment env)
        {
            return env.IsDevelopment() || env.EnvironmentName.StartsWith("Local");
        }
    }
}