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
    public class BookMasters1Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();

        // GET: BookMasters1
        public ActionResult Index()
        {
            var IssuesList = new List<System.Collections.IList>();
            IssuesList.Add(new List<string>() { "a" ,"b"} );
            ViewBag.IssuesList = IssuesList;
            var IssuesList2 = new List<System.Collections.IList>();
            IssuesList2.Add(new List<BookMaster>() { new BookMaster() {  strAccessionId="1"} });
            ViewBag.IssuesList2 = IssuesList2;
            return View(db.BookMasters.ToList());
        }

        // GET: BookMasters1/Details/5
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
        [HttpGet]
        public JsonResult GetItem()
        {
            //var Issued = db.Clearances.Select(a => a.AssignId).ToList();
            //var NotIssued = db.Assigns.Where(Clearance => !Issued.Contains(Clearance.AssignId))
            //    .Select(x => new { AssignId = x.AssignId, Item = x.IatpRequest.Item.ItemName }).ToList();
            List<ass> c = new List<ass>() { new ass() { AssignId=1, Item= "Apple" }, new ass() { AssignId = 3, Item = "Mango" } };
            return Json(c, JsonRequestBehavior.AllowGet);

        }
        public class ass {
            public int AssignId { get; set; }
            public string Item { get; set; }

        }

        // GET: BookMasters1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookMasters1/Create
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

        // GET: BookMasters1/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: BookMasters1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,strBookTypeId,strAccessionId")] BookMaster bookMaster)
        {
            //db.BookMasters.OrderBy(a=>a.Id).ThenBy(a=>a.strAccessionId)
            if (ModelState.IsValid)
            {
                db.Entry(bookMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookMaster);
        }

        // GET: BookMasters1/Delete/5
        public ActionResult Delete( )
        {
            
            return View( );
        }

        // POST: BookMasters1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookMaster bookMaster = db.BookMasters.Find(id);
            db.BookMasters.Remove(bookMaster);
            db.SaveChanges();
            return RedirectToAction("Index");
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
