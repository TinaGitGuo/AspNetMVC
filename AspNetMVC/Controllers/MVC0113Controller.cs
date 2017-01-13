using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMVC;
using System.Web.Helpers;

namespace AspNetMVC.Controllers
{
    public class MVC0113Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();

        // GET: MVC0113
        public ActionResult Index()
        {
            return View(db.BookMasters.ToList());
        }
        //[HttpPost]
        //string chartkey = "0", string chartType = "bar"
        public PartialViewResult _GetChartImage(string chartkey = "0", string chartType = "bar") {
            ViewBag.chartkey = chartkey;
            ViewBag.chartType = chartType;
            return   PartialView()  ;
        }
        public ActionResult CreatePieChart(string chartkey  , string chartType)
        {
            //string[] h =
            //    db.BookMasters..strBookTypeId
            //if (id == "0")
            //{
            //}
            var chart = new Chart(width: 300, height: 200)
                .AddTitle("Chart1")
                .AddSeries(
                //chartType: "bar",
                chartType: chartType,
                xValue: new[] { "10 records", "20 records", "30 records", "40 records" },
                yValues: new[] { "50", "60", "70", "80" })
                .GetBytes("png");
            return File(chart, "image/png");
        }
        #region orengin
        // GET: MVC0113/Details/5
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

        // GET: MVC0113/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVC0113/Create
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

        // GET: MVC0113/Edit/5
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

        // POST: MVC0113/Edit/5
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

        // GET: MVC0113/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: MVC0113/Delete/5
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
        #endregion
    }
}
