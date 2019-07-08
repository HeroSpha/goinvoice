using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class LicenceType
    {
        [Key]
        public int LicenceTypeId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Amount { get; set; }
        public virtual Licence Licence { get; set; }

    }
}
