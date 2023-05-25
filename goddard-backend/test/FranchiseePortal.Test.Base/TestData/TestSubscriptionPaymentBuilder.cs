using System.Linq;
using FranchiseePortal.Editions;
using FranchiseePortal.EntityFrameworkCore;
using FranchiseePortal.MultiTenancy.Payments;

namespace FranchiseePortal.Test.Base.TestData
{
    public class TestSubscriptionPaymentBuilder
    {
        private readonly FranchiseePortalDbContext _context;
        private readonly int _tenantId;

        public TestSubscriptionPaymentBuilder(FranchiseePortalDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreatePayments();
        }

        private void CreatePayments()
        {
            var defaultEdition = _context.Editions.First(e => e.Name == EditionManager.DefaultEditionName);

            CreatePayment(1, defaultEdition.Id, _tenantId, 1, "147741");
            CreatePayment(19, defaultEdition.Id, _tenantId, 30, "1477419");
        }

        private void CreatePayment(decimal amount, int editionId, int tenantId, int dayCount, string paymentId)
        {
            _context.SubscriptionPayments.Add(new SubscriptionPayment
            {
                Amount = amount,
                EditionId = editionId,
                TenantId = tenantId,
                DayCount = dayCount,
                ExternalPaymentId = paymentId
            });
        }
    }

}
