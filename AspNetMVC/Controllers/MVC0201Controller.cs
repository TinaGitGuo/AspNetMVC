using AspNetMVC.Models;
using AspNetMVC.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0201Controller : Controller
    {
        MovieDBContext db = new MovieDBContext();
        // GET: MVC0201
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2() {
          
            db.Database.CreateIfNotExists();
            db.MovieTitles.Add(new Movie() { MovieTitle = "e" });
             db.SaveChanges();
           
            var c = db.MovieTitles.FirstOrDefault();
            var d = db.MovieTitles.ToList();
            
            var MovieTitles = from mv in db.MovieTitles  //This is where it blows up
                              select new { mv.MovieTitle };
            return View(new BookMaster() { Id=6});
        }
       
        public ActionResult Search(MovieV mvV)
        {
            //bookmark -- why is database context empty?
            var newMovie = new Movie();
            newMovie.MovieTitle = "American Pie";
            using (db)
            {
                db.MovieTitles.Add(newMovie);
                db.SaveChanges();
                var MovieTitles = from mv in db.MovieTitles  //This is where it blows up
                                  select new { mv.MovieTitle };
                var listmvV = MovieTitles.ToList();
            }
            return Content("no");
        }
            //public ActionResult Create()
            //{
            //    //ViewData["client"] = "";// GetSelectListItem(); //1.Assigning value to variables ViewData["nameList"] 
            //    ViewBag.SortedFunds = new SelectList(db.Ports.ToList().GroupBy(c => c.Fund).Select(g => g.First()), "Fund", "Fund");
            //    ViewBag.SortedClients = new SelectList(db.Ports.ToList().GroupBy(c => c.LastName).Select(g => g.First()), "LastName", "LastName");
            //    return View();
            //}

            //[HttpPost]

            //public ActionResult Create(Investment param)
            //{
            //    var purchaseDate = param.PurchaseDate;
            //    var lastName = param.LastName;
            //    var fund = param.Fund;

            //    if (!ModelState.IsValid)
            //        return View();

            //    //report query

            //    var result = (from res in context.Investments
            //                  where res.LastName == lastName
            //                  where res.Fund == fund
            //                  where res.PurchaseDate >= purchaseDate
            //                  select res).ToList();


            //    //return RedirectToAction("Index");

            //    return View(result);
            //}

        }
}