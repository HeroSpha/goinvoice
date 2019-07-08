using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Interface
{
    public interface IQuotationRepository
    {
        Task<Quotation> AddQuotationAsync(Quotation quotation);
        Task<Quotation> UpdateQuotationAsync(Quotation quotation);
        Task<List<Quotation>> GetOrganisationQuotationsAsync(int organisationId);
        Task<List<Quotation>> GetCompanyQuotationsAsync(int clientId);
        Task<bool> DeleteQuotationAsync(int QuotationId);
    }
}
