         using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ApplicatioDbContext0403())
            {
                db.Database.Delete();           
                db.Database.CreateIfNotExists();

                Supplier su = new Supplier() { SupplierName = "person1" };

                Town to=  new Town() { TownName = "TownName" };
                Street st = new Street() { StreetName = "StreetName" };
                su.Town = to;
                su.Street = st;
                db.Supplier.Add(su);               
                db.SaveChanges();

               Town to2= new Town() { TownName = "TownName2" , Streets=new List<Street>()};
               Town to3 = new Town() { TownName = "TownName3" };
                Street st2 = new Street() { StreetName = "StreetName2" };
                Street st3 = new Street() { StreetName = "StreetName3" };
                //to2.Streets =new System.Collections.Generic.List<Street>() { st2 ,st3};
                //to3.Streets = new System.Collections.Generic.List<Street>() { st };

                //st3.Town = new System.Collections.Generic.List<Town>() { to2 };
                db.Town.Add(to2);
                //db.Street.Add(st3);

                db.SaveChanges();

                //db.Street.Add(new Street() {  })
                //db.Supplier.Add(new Supplier() { Name = "person2" });



                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            using (var db = new ApplicatioDbContext())
            {
                // Create and save a new Blog 
                //Console.Write("Enter a name for a new Blog: ");
                //var name = Console.ReadLine();
                //db.Database.CreateIfNotExists();
                //db.Contact1s.Add(new Contact1() { Accountno="v", Recid = "1" });
                ////var blog = new Blog { Name = name };
                ////db.Blogs.Add(blog);
                db.Database.CreateIfNotExists();
                 db.SaveChanges();

                // Display all Blogs from the database 
                //var query = from b in db.Blogs
                //            orderby b.Name
                //            select b;

                //Console.WriteLine("All blogs in the database:");
                //foreach (var item in query)
                //{
                //    Console.WriteLine(item.Name);
                //}

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
