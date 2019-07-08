using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class Licence
    {
        [Key]
        public int LicenceId { get; set; }
        public int OrganisationId { get; set; }
        public string   Status { get; set; }
        public int LicenceTypeId { get; set; }
        public virtual Organisation Organisation { get; set; }
        public virtual LicenceType LicenceType { get; set; }

    }
}
