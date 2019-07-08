using GoInvoice.MobileAppService.Core.Interface;
using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Repository
{
    public class BankRepository : IBankRepository
    {
        public Task<Bank> AddBankAsyn(Bank bank)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBankAsync(int bankId)
        {
            throw new NotImplementedException();
        }

        public Task<Bank> UpdateBankAsyn(Bank bank)
        {
            throw new NotImplementedException();
        }
    }
}
