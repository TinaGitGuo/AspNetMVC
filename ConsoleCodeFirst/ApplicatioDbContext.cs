using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    public class Student
    {
        public Student() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual StudentAddress Address { get; set; }

    }

    public class StudentAddress
    {
        public int StudentId { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }

    public class ApplicatioDbContext : DbContext

    {
      
        public ApplicatioDbContext()
            : base("name=CodeFirstDbDemo")
        {
        }

        //public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure StudentId as PK for StudentAddress
            modelBuilder.Entity<StudentAddress>()
                .HasKey(e => e.StudentId);

            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Student>()
                        .HasOptional(s => s.Address)
                        .WithRequired(ad => ad.Student);
            modelBuilder.Entity<Contact1>().HasKey(e => e.Accountno);
            modelBuilder.Entity<Contact4>().HasKey(e => e.Accountno);
            modelBuilder.Entity<Contact1>().HasOptional(s => s.Contact4s).WithRequired(ad => ad.Contact1s);
            //modelBuilder.Entity<Contact1>()
            //   .HasOptional(s => s.Contact2s) // Mark Address property optional in Student entity
            //   .WithRequired(ad => ad.Accountno1); 

            // 
            //var model = modelBuilder.Entity<Contact1>() 
            //     .HasForeignKey(c=>c.Accountno,"e")
            //     .HasKey(c1 => c1.Accountno);
            //     //.HasOne(c2 => c2.Contact2s)
            //     //      .WithOne(c1 => c1.Contact1)

            //model.Property(e => e.Recid)
            //              .HasColumnName("recid")
            //              .HasColumnType("varchar(15)").IsRequired();
            //model.Property(e => e.Accountno)                     
            //              .HasColumnName("ACCOUNTNO")
            //              .HasColumnType("varchar(20)");
            //modelBuilder.Entity<Contact1>().ToTable("Contact1");


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
        public DbSet<Student> students { get; set; }
        public DbSet<StudentAddress> studentAddress { get; set; }
        public DbSet<Contact1> Contact1ss { get; set; }
        public DbSet<Contact4> Contact2ss { get; set; }
    }
}
