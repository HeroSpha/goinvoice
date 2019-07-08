using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class OrganisationSetting
    {
        [Key]
        public int OrganisationSettingsId { get; set; }
        public string Payment { get; set; }
        public int OrganisationId { get; set; }
        public virtual Organisation Organisation { get; set; }
    }
}
