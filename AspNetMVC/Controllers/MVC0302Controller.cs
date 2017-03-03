using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0302Controller : Controller
    {
        // GET: MVC0302
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();

        // GET: BookMasters1
        public ActionResult Index(   )
        {
            var MyGup = (from plan in db.BookMasters
                         join feat in db.Publishers
                         on plan.Id.ToString() equals feat.PublisherId  
                         select plan) ;
            return View(MyGup);
        }
       
        public void ExportData()
        {
            Response.ClearContent();
           
            Response.ContentType = "application/force-download";
            Response.AddHeader("content-disposition",
                "attachment; filename=" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls");
            Response.Write("<html xmlns:x=\"urn:schemas-microsoft-com:office:excel\">");
            Response.Write("<head>");
            Response.Write("<META http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">");
            //string fileCss = Server.MapPath("~/css/daoChuCSS.css");
            //string cssText = string.Empty;
            //StreamReader sr = new StreamReader(fileCss);
            //var line = string.Empty;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    cssText += line;
            //}
            //sr.Close();
            //Response.Write("<style>" + cssText + "</style>");
            Response.Write("<!--[if gte mso 9]><xml>");
            Response.Write("<x:ExcelWorkbook>");
            Response.Write("<x:ExcelWorksheets>");
            Response.Write("<x:ExcelWorksheet>");
            Response.Write("<x:Name>Report Data</x:Name>");
            Response.Write("<x:WorksheetOptions>");
            Response.Write("<x:Print>");
            Response.Write("<x:ValidPrinterInfo/>");
            Response.Write("</x:Print>");
            Response.Write("</x:WorksheetOptions>");
            Response.Write("</x:ExcelWorksheet>");
            Response.Write("</x:ExcelWorksheets>");
            Response.Write("</x:ExcelWorkbook>");
            Response.Write("</xml>");
            Response.Write("<![endif]--> ");

 
            View("~/Views/MVC0302/Index.cshtml",db.BookMasters.ToList()).ExecuteResult(this.ControllerContext);
           
            Response.Flush();
            Response.End();
        }
    }
}