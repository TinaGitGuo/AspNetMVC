using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using identy.Models;

namespace identy.Controllers
{
    public class BookMastersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BookMasters
        public ActionResult Index()
        {
            return View(db.BookMasters.ToList());
        }
        [HttpPost]
        public ActionResult Index0110(string UnAssignedGroupList)
        {
            if (string.IsNullOrEmpty(UnAssignedGroupList))
            {
                ModelState.AddModelError("error ", " At least one unassgined group is Required.");
                ViewData["UnAssignedGroupList"] = GetSelectListItem();
                return View();
            }
            return Redirect("");
        }
        public List<SelectListItem> GetSelectListItem()
        {
            return new List<SelectListItem>()
                {
                new SelectListItem(){Text="null",Value=""},
                new SelectListItem(){Text="one",Value="001"},
                new SelectListItem(){Text="two",Value="002",Selected=true}
                 };
        }
        public ActionResult Index0110()
        {

            ViewData["nameList"] = GetSelectListItem();
            //ViewData["nameList"] = list;

            //At least one unassgined group is Required.
            ViewBag.Message = "Your contact page.";
            //var model = db.BookMasters.Where(u => u.Id == 1).FirstOrDefault();
            return View(new BookMaster());
        }
        // GET: BookMasters/Details/5
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

        // GET: BookMasters/Create
        public ActionResult Create()
        {
            ViewData["nameList"] = GetSelectListItem();
            return View();
        }

        // POST: BookMasters/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,strBookTypeId")] BookMaster bookMaster)
        {
            if (ModelState.IsValid)
            {
                db.BookMasters.Add(bookMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("strBookTypeIdd ", " strBookTypeIdd At least one unassgined group is Required.");
            
             
            ViewData["nameList"] = GetSelectListItem();
            return View(bookMaster);
        }

        // GET: BookMasters/Edit/5
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

        // POST: BookMasters/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,strBookTypeId")] BookMaster bookMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookMaster);
        }

        // GET: BookMasters/Delete/5
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

        // POST: BookMasters/Delete/5
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
