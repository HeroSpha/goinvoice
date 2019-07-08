using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class Bank
    {
        public int BankId { get; set; }
        public string Name { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Account { get; set; }
        public string AccountName { get; set; }
        public int OrganisationId { get; set; }
        public virtual Organisation Organisation { get; set; }
    }
}
