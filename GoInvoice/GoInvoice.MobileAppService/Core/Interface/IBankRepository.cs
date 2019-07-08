using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Interface
{
    public interface IBankRepository
    {
        Task<Bank> AddBankAsyn(Bank bank);
        Task<Bank> UpdateBankAsyn(Bank bank);
        Task<bool> DeleteBankAsync(int bankId);

    }
}
