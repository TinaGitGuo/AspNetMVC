using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    public class ApplicatioDbContext0403 : DbContext

    {
      
        public ApplicatioDbContext0403()
            : base("name=CodeFirstDbDemo0403")
        {
        }

        //public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {




            //modelBuilder.Entity<Street>()
            //    .HasOptional<Town>(s => s.Town)
            //    .WithMany(c => c.Streets)
            //    .Map(cs =>
            //    {
            //        cs.MapKey("StreetID");
            //        cs.MapKey("TownID");
            //        cs.ToTable("Adress");
            //    });


        }


        public DbSet<Town> Town { get; set; }
        public DbSet<Street> Street { get; set; }
        //public DbSet<Adress> Adress { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

    }
}
