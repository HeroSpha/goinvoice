using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Interface
{
    public interface ILicenceTypeRepository
    {
        Task<LicenceType> AddLicenceTypeAsync(LicenceType licenceType);
        Task<LicenceType> UpdateLicenceTypeAsync(LicenceType licenceType);
        Task<List<LicenceType>> GetLicenceTypesAsync();
        Task<bool> DeleteAsync(int licenceTypeId);
    }
}
