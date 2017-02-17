using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
   
  public  class MyPerson1 {
        public MyPerson1()
        {
            MyIds = new MyId1();
        }


        //public int UserId { get; set; }
        //public int IdPart1 { get; set; }

        //public int IdPart2 { get; set; }
        public MyId1 MyIds { get; set; }
        public string Name { get; set; }
}
 
public class MyId1
    {
        //public MyId1()
        //{

        //}
        public   string IdPart1 { get; set; }

      public string  IdPart2 { get; set; }
    }

 
    public class ApplicatioDbContext0217 : DbContext

    {
      
        public ApplicatioDbContext0217()
            : base("name=CodeFirstDbDemo0217")
        {
        }

        //public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

       
            modelBuilder.ComplexType<MyId1>();
            //modelBuilder.ComplexType<MyId1>().Property(p => p.IdPart2) ;
            modelBuilder.Entity<MyPerson1>().HasKey(p =>new string(p.MyIds.IdPart1.ToString())  );
            //base.OnModelCreating(modelBuilder);
        }
        

        public DbSet<MyPerson> MyPersons { get; set; }
        //public DbSet<MyId> MyIds { get; set; }
    }
}
