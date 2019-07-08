using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Interface
{
    public interface IOrganisationRepository
    {
        Task<OrganisationSetting> AddQuotationSettingAsync(OrganisationSetting organisationSetting);
        Task<OrganisationSetting> UpdateQuotationSettingAsync(OrganisationSetting organisationSetting);
        Task<bool> DeleteQuotationSettingAsync(int organisationSettingId);
    }
}
