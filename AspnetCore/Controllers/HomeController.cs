using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspnetCore.Data;
using AspnetCore;

namespace AspnetCore.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db ;
        public HomeController(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {

            // Create and save a new Blog 
            //Console.Write("Enter a name for a new Blog: ");
            //var name = Console.ReadLine();
            //db.Database.CreateIfNotExists();
            //db.Contact1s.Add(new Contact1() { Accountno="v", Recid = "1" });
            ////var blog = new Blog { Name = name };
            ////db.Blogs.Add(blog);
            //db.Database.EnsureCreated();
            for (int i = 2; i < 6; i++) {

           db.Contact1ss.Add(new Contact1() { Accountno = i.ToString() ,Recid="Recid"+i, Company= "Company"+i });
            }
           
            db.SaveChanges();

            return View();
        }

        public IActionResult About()
        {
            //db.Contact1ss.FirstOrDefault();
            ViewData["Message"] = "Your application description page.";
             
            return View(new Contact1() { Birth_Date = DateTime.Now });
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
