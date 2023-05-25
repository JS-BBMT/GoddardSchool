using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Model;
using System;
using System.Threading.Tasks;

namespace FranchiseePortal.TooltipsEditor
{
    public class TooltipAppService : FranchiseePortalAppServiceBase, ITooltipAppService
    {
        private const string baseTooltipPath = "/api/assets/fbp/tooltips/";
        private readonly ITooltipsApi _tooltipApi;
        
        public TooltipAppService(ITooltipsApi tooltipApi)
        {
            _tooltipApi = tooltipApi;
        }

        public async Task<TooltipDto> GetTooltip(string componentPath)
        {
            try
            {
                return await _tooltipApi.ApiV1DcpTooltipsGetAsync(baseTooltipPath, componentPath);
            }
            catch (Exception ex)
            {
                //swallow error
                return null;
            }
        }
    }
}
