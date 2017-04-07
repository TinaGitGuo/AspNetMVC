using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                Town to = new Town() { TownName = "TownName" };
                Street st = new Street() { StreetName = "StreetName" };

                Supplier su2 = new Supplier() { SupplierName = "person2" };
                Town to2 = new Town() { TownName = "TownName2" };
                Street st2 = new Street() { StreetName = "StreetName2" };

                Adress ad = new Adress() { /*Town = to, Street = st,*/ NumberAdress = 100 };
                Adress ad2 = new Adress() { /*Town = to, Street = st,*/ NumberAdress = 200 };
                su.Town = to;
                su.Street = st;
                su.Adress = ad;
                su2.Town = to2;
                su2.Street = st2;
                su2.Adress = ad2;

                db.Supplier.Add(su);
                db.SaveChanges();
                db.Supplier.Add(su2);

                db.SaveChanges();

                Supplier a1 = new Supplier() { SupplierID = 2, StreetID = 1, TownID = 1, SupplierName = "abc"  };
               a1= db.Supplier.Where(r => r.SupplierID == 2).FirstOrDefault();
                
                a1.SupplierName = "12e34";
                a1.StreetID = 1;
               
                IEnumerable< Supplier> a = db.Supplier.ToList();
                IEnumerable< Adress > c = db.Adress.ToList();
                Adress add = db.Supplier.Where(r => r.SupplierID == 2).FirstOrDefault().Adress;
                db.Adress.Remove(add);
                //add.StreetID = 1;
                Adress add2 = add;
                //db.Adress.Add();
                a1.Adress = new Adress() { StreetID = 1, TownID = 2, NumberAdress = add.NumberAdress };
                //Town to2= new Town() { TownName = "TownName2" , Streets=new List<Street>()};
                //Town to3 = new Town() { TownName = "TownName3" };
                // Street st2 = new Street() { StreetName = "StreetName2" };
                // Street st3 = new Street() { StreetName = "StreetName3" };
                //to2.Streets =new System.Collections.Generic.List<Street>() { st2 ,st3};
                //to3.Streets = new System.Collections.Generic.List<Street>() { st };

                //st3.Town = new System.Collections.Generic.List<Town>() { to2 };
                //db.Town.Add(to2);
                ////db.Street.Add(st3);

                //db.SaveChanges();

                //a1.Adress= db.Supplier.Find(2).Adress;
                //db.Street.Add(new Street() {  })
                //db.Supplier.Add(new Supplier() { Name = "person2" });

                //a1.Town = db.Town.Find(1);
                //a1.Street = db.Street.Find(1);

                //a1.Adress = db.Adress.Where(v => v.StreetID == 1 && v.TownID == 1).FirstOrDefault();
                db.Entry(a1).State = EntityState.Modified;
                //db.Supplier.Add(a1);


                db.SaveChanges();
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
