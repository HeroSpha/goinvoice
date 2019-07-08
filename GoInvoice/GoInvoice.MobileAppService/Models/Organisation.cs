using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Models
{
    public class Organisation
    {
        [Key]
        public int OrganisationId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Slogan { get; set; }
        public string Logo { get; set; }
        public virtual Account Account { get; set; }
        public virtual Licence Licence { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual OrganisationSetting OrganisationSetting  { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
        public virtual ICollection<Bank> Banks { get; set; }
    }
}
