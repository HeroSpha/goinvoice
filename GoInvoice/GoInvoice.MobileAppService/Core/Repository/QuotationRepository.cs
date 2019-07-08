using GoInvoice.MobileAppService.Core.Interface;
using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Repository
{
    public class QuotationRepository : IQuotationRepository
    {
        public Task<Quotation> AddQuotationAsync(Quotation quotation)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteQuotationAsync(int QuotationId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Quotation>> GetCompanyQuotationsAsync(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Quotation>> GetOrganisationQuotationsAsync(int organisationId)
        {
            throw new NotImplementedException();
        }

        public Task<Quotation> UpdateQuotationAsync(Quotation quotation)
        {
            throw new NotImplementedException();
        }
    }
}
