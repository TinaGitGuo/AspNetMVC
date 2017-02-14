using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0208Controller : Controller
    {
        // GET: MVC0208

        //public ActionResult Edit(Furniture furniture, HttpPostedFileBase fileTwo, HttpPostedFileBase file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //New Files
        //        for (int i = 0; i < Request.Files.Count; i++)
        //        {
        //            fileTwo = Request.Files[i];

        //            if (fileTwo != null && fileTwo.ContentLength > 0)
        //            {
        //                var fileNameTwo = Path.GetFileName(fileTwo.FileName);
        //                MainFileDetails mainFileDetail = new MainFileDetails()
        //                {
        //                    FileName = fileNameTwo,
        //                    Extension = Path.GetExtension(fileNameTwo),
        //                    Id = Guid.NewGuid(),
        //                    FurnitureId = furniture.FurnitureId
        //                };
        //                var pathMain = Path.Combine(Server.MapPath("~/Upload/MainPage/"), mainFileDetail.Id + mainFileDetail.Extension);
        //                fileTwo.SaveAs(pathMain);

        //                db.Entry(mainFileDetail).State = EntityState.Modified;

                       
        //                FileDetail fileDetail = new FileDetail()
        //                {
        //                    NameFile = fileNameTwo, //or mainFileDetail.FileName
        //                    Extension = Path.GetExtension(fileNameTwo),//or mainFileDetail.Extension
        //                    Id = Guid.NewGuid(),
        //                    FurnitureId = furniture.FurnitureId //or mainFileDetail. FurnitureId
        //                };
        //                var path = Path.Combine(Server.MapPath("~/Upload/"), fileDetail.Id + fileDetail.Extension);
        //                fileTwo.SaveAs(path);

        //                db.Entry(fileDetail).State = EntityState.Added;


        //            }            
        //        }

        //        db.Entry(furniture).State = EntityState.Modified;
        //        db.SaveChanges();

        //        TempData["message"] = string.Format("Changes in \"{0}\" has been saved", furniture.Name);
        //        return RedirectToAction("Index");

        //    }

        //    ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name", furniture.CategoryId);
        //    return View(furniture);
        //}

        public ActionResult Index()
        {
            return View();
        }
    }
}