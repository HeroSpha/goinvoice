using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Interface
{
    public interface ICountryRepository
    {
        Task<bool> AddCountriesAsync(List<Country> countries);
        Task<List<Country>> GetCountriesAsync();
    }
}
