using Abp.Events.Bus;

namespace FranchiseePortal.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}