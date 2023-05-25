using Abp.Auditing;
using FranchiseePortal.Configuration.Dto;

namespace FranchiseePortal.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}