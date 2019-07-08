using GoInvoice.MobileAppService.Core.Interface;
using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Repository
{
    public class LicenceRepository : ILicenceRepository
    {
        public Task<Licence> AddLicenceAsync(Licence licence)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLicenceAsync(int licenceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Licence>> GetLicencesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Licence> UpdateLicenceAsync(Licence licence)
        {
            throw new NotImplementedException();
        }
    }
}
