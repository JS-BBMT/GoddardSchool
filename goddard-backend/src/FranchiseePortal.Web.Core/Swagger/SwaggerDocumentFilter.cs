using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using System.Reflection;

namespace FranchiseePortal.Web.Swagger
{
    public class SwaggerDocumentFilter : IDocumentFilter
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public SwaggerDocumentFilter(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            // 20220615RBP - FIX: Custom document filter to exclude conventional routes when ?excludeConventionalRoutes is specified
            // by client-side nswag to fix .ts "Duplicate function implementation" errors.
            // This happens because an operation on ProfileControllerBase collides with ProfileAppService.
            // Conventional routes are not used by the TypeScript client so the config has been updated to include
            // ?excludeConventionalRoutes to the swagger.json URL to exclude them.
            // These error started happening when we enabled Swagger to expose MVC convention routes for APIM
            if (_contextAccessor.HttpContext != null
                && _contextAccessor.HttpContext.Request.Query.ContainsKey("excludeConventionalRoutes"))
            {
                RemoveConventionalRoutes(swaggerDoc, context);
            }

            RemoveSwaggerHideDocumentRoutes(swaggerDoc, context);
        }

        public void RemoveConventionalRoutes(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            // Remove paths that do not start with /api
            // based on: https://stackoverflow.com/a/36205198
            var pathsToRemove = swaggerDoc.Paths.Keys.Where(x => !x.StartsWith("/api/"));
            foreach(var key in pathsToRemove)
            {
                swaggerDoc.Paths.Remove(key);
            }
        }

        public void RemoveSwaggerHideDocumentRoutes(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            // tja 20220617
            // Remove paths that have a [SwaggerHideDocumentAttribute]
            // Using to remove routes that break swagger validity since the upgrade to aspnetzero 10.0.5
            foreach (var contextApiDescription in context.ApiDescriptions)
            {
                var actionDescriptor = (Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)contextApiDescription.ActionDescriptor;

                if (actionDescriptor.ControllerTypeInfo.GetCustomAttributes<SwaggerHideDocumentAttribute>().Any() ||
                   actionDescriptor.MethodInfo.GetCustomAttributes<SwaggerHideDocumentAttribute>().Any())
                {
                    var key = "/" + contextApiDescription.RelativePath.TrimEnd('/');
                    swaggerDoc.Paths.Remove(key);
                }
            }
        }
    }
}
