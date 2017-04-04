using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CountryId { get; set; }

        [DisplayName("Country")]
        public string CountryName { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        //public virtual ICollection<State> States { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }

    }

    public class State
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int StateId { get; set; }

        [DisplayName("State")]
        public string StateName { get; set; }
        //public int CountryId { get; set; }
        public virtual ICollection< Country> Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }

    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CityId { get; set; }

        [DisplayName("City")]
        public string CityName { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }

    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter Customer Name")]
        public string CustomerName { get; set; }

        [DisplayName("Country")]

        public int CountryId { get; set; }

        [DisplayName("State")]
        public int StateId { get; set; }

        [DisplayName("City")]
        public int CityId { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual City City { get; set; }
    }


    public class ApplicatioDbContext0325 : DbContext

    {
      
        public ApplicatioDbContext0325()
            : base("name=CodeFirstDbDemo0325")
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }

        public DbSet<State> State { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<State>().HasMany(t => t.Customers).WithRequired(a=>a.State).WillCascadeOnDelete(false);
            modelBuilder.Entity<State>().HasMany(t => t.Cities).WithRequired(a => a.State).WillCascadeOnDelete(false);
            modelBuilder.Entity<State>().HasMany(t => t.Country).WithRequired(a => a.State).WillCascadeOnDelete(false);
        }
       
    }
}
