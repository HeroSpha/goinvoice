using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class Quotation
    {
        [Key]
        public int QuotationId { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public string QuotationType { get; set; }
        public string Type { get; set; }
        public double Tax { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual Organisation Organisation { get; set; }
    }
}
