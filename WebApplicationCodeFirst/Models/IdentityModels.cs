using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplicationCodeFirst.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Contact1>(entity =>
        //    {
        //        entity.HasKey(c1 => c1.Accountno);


        //        entity.HasOne(c2 => c2.Contact2s)
        //              .WithOne(c1 => c1.Contact1)
        //              .HasForeignKey<Contact2>(c2 => c2.Accountno);
        //        entity.Property(e => e.Recid)
        //                  .HasColumnName("recid")
        //                  .HasColumnType("varchar(15)");

        //        entity.Property(e => e.Accountno)
        //                 .IsRequired()
        //                  .HasColumnName("ACCOUNTNO")
        //                  .HasColumnType("varchar(20)");
        //    });

        //    //modelBuilder.Entity<Contact2>(entity =>
        //    //{
        //    //    entity.HasKey(e => e.Accountno);

        //    //    entity.HasOne(c1 => c1.Contact1)
        //    //    .WithOne(c2 => c2.Contact2);


        //    //    entity.Property(e => e.Recid)
        //    //              .HasColumnName("recid")
        //    //              .HasColumnType("varchar(15)");

        //    //    entity.Property(e => e.Accountno)
        //    //              .IsRequired()
        //    //              .HasColumnName("ACCOUNTNO")
        //    //              .HasColumnType("varchar(20)");

        //    //    entity.Property(e => e.Callbackon)
        //    //              .HasColumnName("CALLBACKON")
        //    //              .HasColumnType("datetime");

        //    //});

        //    //base.OnModelCreating(modelBuilder);
        //}
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}