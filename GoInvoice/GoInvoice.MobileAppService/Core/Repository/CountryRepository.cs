using GoInvoice.MobileAppService.Core.Interface;
using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Repository
{
    public class CountryRepository : ICountryRepository
    {
        public Task<bool> AddCountriesAsync(List<Country> countries)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> GetCountriesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
