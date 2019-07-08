using GoInvoice.MobileAppService.Core.Interface;
using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Repository
{
    public class OrganisationRepository : IOrganisationRepository
    {
        public Task<OrganisationSetting> AddQuotationSettingAsync(OrganisationSetting organisationSetting)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteQuotationSettingAsync(int organisationSettingId)
        {
            throw new NotImplementedException();
        }

        public Task<OrganisationSetting> UpdateQuotationSettingAsync(OrganisationSetting organisationSetting)
        {
            throw new NotImplementedException();
        }
    }
}
