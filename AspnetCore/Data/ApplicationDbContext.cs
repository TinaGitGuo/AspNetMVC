using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspnetCore.Models;

namespace AspnetCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
            
        //    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");
        //    optionsBuilder.UseSqlServer(@"data source = VDI-V-TIGUO; initial catalog = CodeFirstDbDemo8; integrated security = True;");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Contact1>(entity =>
            {
                entity.HasKey(e => e.Accountno);
                entity.Property(e => e.Recid).IsRequired();
            });

            builder.Entity<Contact4>(entity =>
            {
                entity.HasKey(e => e.Accountno);
                entity.HasOne(d => d.Contact1s)
                    .WithOne(p => p.Contact4s);
                    
                    //.HasForeignKey(d => d.);
            });

            //builder.Entity<Contact1>().HasKey(e => e.Accountno);
            //builder.Entity<Contact4>().HasKey(e => e.Accountno);
            //builder.Entity<Contact1>().HasOptional(s => s.Contact4s).WithRequired(ad => ad.Contact1s);
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Contact1> Contact1ss { get; set; }
        public DbSet<Contact4> Contact2ss { get; set; }
    }
}
