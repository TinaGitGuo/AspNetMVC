using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMVC;

namespace AspNetMVC.Controllers
{
    public class MVC0124Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();

        // GET: MVC0124
        public ActionResult Index()
        {
            return View(db.BookMasters.ToList());
        }

        // GET: MVC0124/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             
           BookMaster bookMaster = db.BookMasters.Find(id);
            if (bookMaster == null)
            {
                return HttpNotFound();
            }
            return View(bookMaster);
        }

        // GET: MVC0124/Create
        public ActionResult Create()
        {
            //var categories = db.BookMasters.Select(c => new List< SelectListItem>()
            //{new SelectListItem() { 
            //    Text = c.strBookTypeId,
            //    Value = c.Id.ToString()
            //}}) ;
            //http://www.mikesdotnetting.com/article/265/asp-net-mvc-dropdownlists-multiple-selection-and-enum-support
            ViewBag.list = new MultiSelectList(db.BookMasters, "Id", "strBookTypeId", new[] { 1, 2 });
            return View();
        }

        // POST: MVC0124/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,strBookTypeId,strAccessionId")] BookMaster bookMaster)
        {
            if (ModelState.IsValid)
            {
                db.BookMasters.Add(bookMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookMaster);
        }
        public class BookMasterModel
        {
            public int Id { get; set; }
           
        }
        // GET: MVC0124/Edit/5
        public ActionResult Edit()
        {
            BookMaster b= new BookMaster();
           //IEnumerable< List<BookMaster>>  c =  from a in  db.BookMasters   select new  List<BookMaster>() { new BookMaster() { Id = a.Id } }.ToList();
           var c = from a in db.BookMasters select new List< BookMasterModel>() { new BookMasterModel() { Id = a.Id } } ;
           IEnumerable< List<BookMaster>> d = db.BookMasters.Where(m => m.Id == 1).Select(a =>
                new List<BookMaster>() {
                 new BookMaster() { Id = a.Id }
                }
            );

            List<BookMaster> d1 = db.BookMasters.Where(m => m.Id == 1).ToList();
           var d2=  d1.Select(a =>
                new List<BookMaster>() {
                 new BookMaster() { Id = a.Id }
                });
            //db.BookMasters.ToList();

            //var categories = db.BookMasters.Select(f => new List<BookMaster>()
            //{new BookMaster() {
            //    strBookTypeId = f.strBookTypeId,
            //    Id = f.Id
            //}});
            var t = (from a in db.BookMasters where a.Id==1
                    select a).ToList();
            var t3 = (from a in db.BookMasters
                     where a.Id == 1
                     select a).FirstOrDefault();
            var t1 = db.BookMasters.Where(a=> a.Id == 1).ToList();

            return View(t3);
        }

        // POST: MVC0124/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,strBookTypeId,strAccessionId")] BookMaster bookMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookMaster);
        }

        // GET: MVC0124/Delete/5
        public ActionResult Delete( )
        {
            bool v= ModelState.IsValid;
            return View( );
        }

        //// POST: MVC0124/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(BookMaster bm)
        {
            bool v = ModelState.IsValid;
            //BookMaster bookMaster = db.BookMasters.Find(id);
            //db.BookMasters.Remove(bookMaster);
            //db.SaveChanges();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
