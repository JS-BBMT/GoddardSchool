using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using FranchiseePortal.MultiTenancy.Accounting.Dto;

namespace FranchiseePortal.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
