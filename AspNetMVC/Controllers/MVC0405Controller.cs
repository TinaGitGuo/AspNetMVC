using AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0405Controller : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0405
        public ActionResult Index()
        {
            
            db.Database.ExecuteSqlCommand("");

            return View();
        }
        public class Product
        {
     
            public string ProductId { get; set; }

            public string Name { get; set; }


            public int CategoryID { get; set; }
            //public virtual Category Categories { get; set; }

            public virtual IEnumerable<ProductImageMapping> ProductImageMappings { get; set; }

        }

        public class ProductImageMapping
        {
          
            public int Id { get; set; }
            public string ImagePath { get; set; }
            //public Boolean MainImage { get; set; }
            public string ProductId { get; set; }
            public virtual Product Products { get; set; }
        }
        // GET: MVC0405/Details/5
        [ChildActionOnly]
        //[MultipleButton()
        public ActionResult Details(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
          var b=  db.Products.Select(t=>new { t.Name , ImagePath = t.ProductImageMappings.Where(y=>y.ProductId==t.ProductId).FirstOrDefault().ImagePath});
          var a=  Request.Form["a"];
            return View();
        }

        // GET: MVC0405/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //[MultipleButton(Name = "action", Argument = "Submit")]
        public ActionResult Submit(Product d, HttpPostedFileBase upfile, IEnumerable<int> STRMSelected)
        {
           
            return Content("abc");
        }

        // POST: MVC0405/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MVC0405/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MVC0405/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MVC0405/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MVC0405/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
