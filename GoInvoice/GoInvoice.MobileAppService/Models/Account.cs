using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class Account : IdentityUser
    {
        public Account()
        {
            Organisations = new HashSet<Organisation>();
        }
        public string Fullname { get; set; }
        public string Signature { get; set; }
        public virtual ICollection<Organisation> Organisations { get; set; }
    }
}
