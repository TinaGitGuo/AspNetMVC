using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WebApplicationCodeFirst.Models;

namespace WebApplicationCodeFirst
{
    public class ApplicatioDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicatioDbContext()
            : base("name=CodeFirstDbDemo3")
        {
        }

        //public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contact1>(entity =>
            {
                entity.HasKey(c1 => c1.Accountno);


                entity.HasOne(c2 => c2.Contact2s)
                      .WithOne(c1 => c1.Contact1)
                      .HasForeignKey<Contact2>(c2 => c2.Accountno);
                entity.Property(e => e.Recid)
                          .HasColumnName("recid")
                          .HasColumnType("varchar(15)");

                entity.Property(e => e.Accountno)
                         .IsRequired()
                          .HasColumnName("ACCOUNTNO")
                          .HasColumnType("varchar(20)");
            });

            //modelBuilder.Entity<Contact2>(entity =>
            //{
            //    entity.HasKey(e => e.Accountno);

            //    entity.HasOne(c1 => c1.Contact1)
            //    .WithOne(c2 => c2.Contact2);


            //    entity.Property(e => e.Recid)
            //              .HasColumnName("recid")
            //              .HasColumnType("varchar(15)");

            //    entity.Property(e => e.Accountno)
            //              .IsRequired()
            //              .HasColumnName("ACCOUNTNO")
            //              .HasColumnType("varchar(20)");

            //    entity.Property(e => e.Callbackon)
            //              .HasColumnName("CALLBACKON")
            //              .HasColumnType("datetime");

            //});

            //base.OnModelCreating(modelBuilder);
        }
        public   DbSet<Contact1> Contact1s { get; set; }
        public   DbSet<Contact2> Contact2s { get; set; }
    }
}
