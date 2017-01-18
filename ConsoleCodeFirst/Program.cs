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
