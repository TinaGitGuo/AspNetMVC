using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMVC;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace AspNetMVC.Controllers
{
    public class MVC0118Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();

        // GET: MVC0118
    

        // POST: MVC0118/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[HttpPost]
        public JsonResult Create2(  BookMaster bookMaster)
        {
            if (ModelState.IsValid)
            {
                //db.BookMasters.Add(bookMaster);
                //db.SaveChanges();
                return Json(new { Success = true });
                //return RedirectToAction("Index");
            }
            return Json(bookMaster, JsonRequestBehavior.AllowGet);
        }

        // GET: MVC0118/Edit/5
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

        // POST: MVC0118/Edit/5
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
        public ActionResult EditUserExpDetails(tblOpsUserEmpDetail exp)
        {
            var DbEntity = db;
            return Json(new { name=1});
            //try
            //{
            //    if (Session["LoginDetails"] != null)
            //    {    
            //        int userID = Convert.ToInt16(Session["LoginDetails"].ToString());
            //        tblOpsUserEmpDetail tblObj = DbEntity.tblOpsUserEmpDetails.Find(userID);
            //        //ModelState.Remove("Password");
            //        tblObj.userID = userID;
            //        tblObj.modifiedDate = DateTime.Today;
            //        tblObj.empName =
            //            exp.empName ?? tblObj.empName;
            //        tblObj.empAddress = exp.empAddress ?? tblObj.empAddress;
            //        tblObj.annualSalary = exp.annualSalary ?? tblObj.annualSalary;
            //        tblObj.currentDesignation = exp.currentDesignation ?? tblObj.currentDesignation;
            //        tblObj.lastDesignation = exp.lastDesignation ?? tblObj.lastDesignation;
            //        tblObj.joininSalary = exp.joininSalary ?? tblObj.joininSalary;
            //        tblObj.lastSalary = exp.lastSalary ?? tblObj.lastSalary;
            //        tblObj.joiningDate = exp.joiningDate;
            //        tblObj.lastDate = exp.lastDate;
            //        tblObj.createdDate = exp.createdDate;
            //        try
            //        {
            //            DbEntity.Entry(tblObj).State = EntityState.Modified;
            //            DbEntity.SaveChanges();
            //            TempData["Msg"] = "Profile has been updated succeessfully";
            //        }
            //        catch (DbEntityValidationException ex)
            //        {
            //            var error = ex.EntityValidationErrors.First().ValidationErrors.First();
            //            this.ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            //            return View();
            //        }
            //        return RedirectToAction("ViewUserProfile");
            //    }
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //return View(exp);
        }
        // GET: MVC0118/Delete/5
        public class tblOpsUserEmpDetail
        {

            public int userempID { get; set; }
            public int userID { get; set; }
            public string empName { get; set; }
            public string empAddress { get; set; }
            public string currentDesignation { get; set; }
            public string lastDesignation { get; set; }
            public string annualSalary { get; set; }
            public System.DateTime joiningDate { get; set; }
            public System.DateTime lastDate { get; set; }
            public string joininSalary { get; set; }
            public string lastSalary { get; set; }
            public Nullable<System.DateTime> modifiedDate { get; set; }
            public System.DateTime createdDate { get; set; }
        }
        #region orgain
        public ActionResult Index()
        {
            return View(db.BookMasters.ToList());
        }

        // GET: MVC0118/Details/5


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

        // GET: MVC0118/Create
        public ActionResult Create()
        {
            return View();
        }
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

        // POST: MVC0118/Delete/5
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
