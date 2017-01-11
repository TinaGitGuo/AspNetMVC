using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMVC;
using AspNetMVC.Models;

namespace AspNetMVC.Controllers
{
    public class PartalController : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();

        // GET: Partal
        public ActionResult Index()
        {
            return View(db.BookMasters.ToList());
        }
        public PartialViewResult _PartialView(string strBookTypeId) {
            
            return PartialView(db.BookMasters.Where(u => u.strBookTypeId == strBookTypeId));
        }
        // GET: Partal/Details/5
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

        // GET: Partal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Partal/Create
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

        // GET: Partal/Edit/5
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

        // POST: Partal/Edit/5
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

        // GET: Partal/Delete/5
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

        // POST: Partal/Delete/5
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
