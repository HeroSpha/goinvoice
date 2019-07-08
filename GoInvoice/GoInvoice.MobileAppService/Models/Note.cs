using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string Text { get; set; }
        public virtual Quotation Quotation { get; set; }
    }
}
