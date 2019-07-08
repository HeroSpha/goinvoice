using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Interface
{
    public interface ILicenceRepository
    {
        Task<Licence> AddLicenceAsync(Licence licence);
        Task<Licence> UpdateLicenceAsync(Licence licence);
        Task<bool> DeleteLicenceAsync(int licenceId);
        Task<List<Licence>> GetLicencesAsync();
    }
}
