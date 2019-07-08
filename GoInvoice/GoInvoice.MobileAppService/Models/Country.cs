using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class Country
    {
        public Country()
        {
            Organisations = new HashSet<Organisation>();
        }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public virtual ICollection<Organisation> Organisations { get; set; }
    }
}
