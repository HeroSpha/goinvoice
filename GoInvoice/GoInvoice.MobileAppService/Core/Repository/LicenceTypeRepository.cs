using GoInvoice.MobileAppService.Core.Interface;
using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Repository
{
    public class LicenceTypeRepository : ILicenceTypeRepository
    {
        public Task<LicenceType> AddLicenceTypeAsync(LicenceType licenceType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int licenceTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<LicenceType>> GetLicenceTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LicenceType> UpdateLicenceTypeAsync(LicenceType licenceType)
        {
            throw new NotImplementedException();
        }
    }
}
