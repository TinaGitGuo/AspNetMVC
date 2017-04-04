using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace AspNetMVC.Controllers
{
    public class MVC0321Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0321
        public ActionResult Index()
        {
            string strUrl = "http://www.w3school.com.cn/example/xmle/note.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(strUrl);
            return View();
        }
        public ActionResult Index2(string flag = "PHM") {

            ViewBag.flag = flag;
            return View(db.BookMasters.ToList());
        }
        public ActionResult Details(int? id,string  flag= "PHM")
        {
            ViewBag.flag = flag;
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
        [HttpPost]
        public HttpStatusCode Index3(FormCollection form) {
            string FilePath = Server.MapPath("~/Content/") + "Pictures";

            HttpFileCollectionBase  HFC =Request.Files; //Request.Form["file1"]
            for (int i = 0; i < HFC.Count; i++)
            {
                HttpPostedFileBase UserHPF = HFC[i];
                if (UserHPF.ContentLength > 0)
                {

                    string fileName = UserHPF.FileName.Substring(UserHPF.FileName.LastIndexOf("\\"));
                    string pathes = FilePath + "\\" + System.IO.Path.GetFileName(UserHPF.FileName);
                    if (!Directory.Exists(FilePath))
                        Directory.CreateDirectory(FilePath);

                    UserHPF.SaveAs(pathes);


                    Bitmap image = new Bitmap(UserHPF.InputStream);

                    Bitmap target = new Bitmap(50, 50);

                    string pathesSmall = FilePath + "\\smail\\" + System.IO.Path.GetFileName(UserHPF.FileName);
                    Graphics graphic = Graphics.FromImage(target);
                    graphic.DrawImage(image, 0, 0, 50, 50);

                    if (!Directory.Exists(FilePath + "\\smail"))
                        Directory.CreateDirectory(FilePath + "\\smail");
                    target.Save(pathesSmall);


                }

            }
            return HttpStatusCode.OK;
        }
    }
}