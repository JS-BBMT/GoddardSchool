using FranchiseePortal.ContentWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FranchiseePortal.TooltipsEditor
{
    public interface ITooltipAppService
    {
        Task<TooltipDto> GetTooltip(string componentPath);
    }
}