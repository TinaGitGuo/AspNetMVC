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
            using (var db = new ApplicatioDbContext0325())
            {              
                db.Database.CreateIfNotExists();
                db.SaveChanges();
                
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
           
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    
}
