using GoInvoice.MobileAppService.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Data
{
    public class GoContext : IdentityDbContext<Account>
    {
        public GoContext(DbContextOptions<GoContext> options) : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Licence> Licences  { get; set; }
        public virtual DbSet<LicenceType> LicenceTypes { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Organisation> Organisations { get; set; }
        public virtual DbSet<OrganisationSetting> OrganisationSettings { get; set; }
        public virtual DbSet<Quotation> Quotations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bank>()
                .HasOne(p => p.Organisation)
                .WithMany(b => b.Banks)
                .HasForeignKey("Bank")
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Quotation>()
                .HasOne(p => p.Organisation)
                .WithMany(b => b.Quotations)
                .HasForeignKey("Quotation")
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Note>()
                .HasOne(p => p.Quotation)
                .WithMany(a => a.Notes)
                .HasForeignKey("Note")
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Licence>()
                .HasOne(p => p.Organisation)
                .WithOne(b => b.Licence)
                .HasForeignKey("Licence")
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Licence>()
                .HasOne(p => p.LicenceType)
                .WithOne(b => b.Licence)
                .HasForeignKey("Licence")
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Organisation>()
                .HasOne(p => p.Account)
                .WithMany(a => a.Organisations)
                .HasForeignKey("Organisation")
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Organisation>()
               .HasOne(p => p.Country)
               .WithMany(a => a.Organisations)
               .HasForeignKey("Organisation")
               .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<OrganisationSetting>()
              .HasOne(p => p.Organisation)
              .WithOne(a => a.OrganisationSetting)
              .HasForeignKey("OrganisationSetting")
              .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(builder);
        }

    }
}

