using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetMVC.Controllers
{
     
    public class MVC0220Controller : Controller
    {
        public byte[] FileVirtualPath { get; private set; }

        // GET: MVC0220
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2() {
            return View();
        }
        //[HttpPost]
         [Route]
        public ActionResult Index3( )
        {

            ModelState.AddModelError("", "error");
          // Response.Write("ee");
        //    return RedirectToAction("Index2");

           return View("~/Views/MVC0220/Index2.cshtml");
        }
        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="obj"></param>
        public void ExportData(   )
        {
            
                string style = "";
                //if (obj.Rows.Count > 0)
                //{
                //    style = @"<style> .text { mso-number-format:\@; } </script> ";
                //}
                //else
                //{
                //    style = "no data.";
                //}

                Response.ClearContent();
                DateTime dt = DateTime.Now;
                string filename = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString();
                Response.AddHeader("content-disposition", "attachment;filename=ExportData.xlsx");
                //Response.ContentType = "application/ms-excel";
                Response.ContentType = "application/vnd.ms-excel"; 
                Response.Charset = "GB2312";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);


            //GridView
                View().ExecuteResult(this.ControllerContext);
            Response.TrySkipIisCustomErrors = true;
            Response.Write(this);
                this.ControllerContext.HttpContext.Response.End();
                //obj.RenderControl(htw);
                //Response.Write(style);
                //Response.Write(sw.ToString());
                //Response.Write(d.ToString());
                
                //Response.End();
            
        }
        //public virtual ActionResult GetFile()
        //   {
        //       return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
        //   }
        /// <summary>
                /// 导出Excel
                /// </summary>
                /// <param name="obj"></param>
        //public ActionResult ExportData1(   )
        //{

        //  Response.ContentType = "application/vnd.ms-excel"
        //  return   Files();
        //}

        [Route("list.html")]
        [Route("list_{category}.html")]
        [Route("list_{category}_p{page:int}.html")]
        public void ArticleList(string category, int page = 1)
        {
            var title = string.IsNullOrEmpty(category) ? "所有资讯" : category + "资讯";

            Response.Write(string.Format("分类：{0}，页码：{1}<br/>我们都是好孩子！！！", title, page));
        }
        public class Photo
        {
            public  Photo (){
                this.chasr = DateTime.Now;
            }
            [Key]
            public int ID { get; set; }
            public string NameofPhoto { get; set; }
            [ScaffoldColumn(false)]
            public string ImageName { get; set; }
            [NotMapped]
            public HttpPostedFileBase File { get; set; }
            //[DefaultValue(TypeDescriptor DateTime.Now.ToString())]
            //[DefaultValue(  DateTime.Now.ToString())]
            //[DefaultValue(typeof( DateTime),(new TypeConverter()).ConvertToString(DateTime.Now.Day) )]     
            //[DefaultValue(Guid.NewGuid())]
            public DateTime chasr{ get  ;set;}
            private bool myVal = false;

            [DefaultValue(false)]
            public bool MyProperty
            {
                get
                {
                    return myVal;
                }
                set
                {
                    myVal = value;
                }
            }

        }
    

    //this is my controller for the images
    public ActionResult Create()
    {
        return View();
    }
        public async Task<string> G() { 

        var baseAddress = new Uri("http://example.com");
        using (var handler = new HttpClientHandler { UseCookies = false })
        using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
        {
            var message = new HttpRequestMessage(HttpMethod.Get, "/test");
            message.Headers.Add("Cookie", "cookie1=value1; cookie2=value2");
            var result = await client.SendAsync(message);
          return  result.EnsureSuccessStatusCode().ToString();
        }
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,NameofPhoto,ImageName")] Photo photo, HttpPostedFileBase file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var filename = "";
        //            if (file != null && file.ContentLength > 0)
        //            {
        //                Guid gid;
        //                gid = Guid.NewGuid();
        //                var extension = Path.GetExtension(file.FileName);
        //                filename = gid + extension;
        //                var path = Path.Combine(Server.MapPath("~/Content/PhotoGallery/"), filename);
        //                var data = new byte[file.ContentLength];
        //                file.InputStream.Read(data, 0, file.ContentLength);
        //                using (var sw = new FileStream(path, FileMode.Create))
        //                {
        //                    sw.Write(data, 0, data.Length);
        //                }
        //            }
        //            photo.ImageName = filename;
        //            db.Photos.Add(photo);
        //            db.SaveChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            TempData["Message"] = "<div class='alert alert-danger'><a href='#' class='close' data-dismiss='alert'>&times; Directory</a><strong> " + ex.ToString() + "</strong> Not found.</div>";
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    return View(photo);
        //}

        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);//返回状态
        //    }
        //    Photo photo = db.Photos.Find(id);
        //    if (photo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(photo);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,NameofPhoto,ImageName")] Photo photo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            db.Entry(photo).State = EntityState.Modified;
        //            db.Entry(photo).Property("ImageName").IsModified = false;
        //            string path = Server.MapPath("~/Content/PhotoGallery/");
        //            var ImageName = GetImageName(photo.ID);
        //            //string Fromfol = GetAlbumNameByPhotoID(photo.ID) + "/" + ImageName;
        //            //System.IO.File.Move(path + Fromfol); 
        //            db.SaveChanges();
        //        }
        //        catch (IOException ex)
        //        {
        //            TempData["Message"] = "<div class='alert alert-danger'><a href='#' class='close' data-dismiss='alert'>&times; </a><strong> " + ex.ToString() + "</strong> </div>";
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    return View(photo);
        //}
    }
}