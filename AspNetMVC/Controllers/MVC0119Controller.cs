using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Web.Mvc;

using Microsoft.Office.Interop ;
namespace AspNetMVC.Controllers
{
    public class MVC0119Controller : Controller
    {
        
        // GET: MVC0119
        public ActionResult Index()
        {
           string[] strs= "a,b,c".Split(',');
           string firstname = strs[1];
            return View();
        }

        // GET: MVC0119/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: MVC0119/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVC0119/Create
        [HttpPost]
        public ActionResult Create(System.Web.Mvc.FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MVC0119/Edit/5
        public ActionResult Edit( )
        {
            //Microsoft.Office.Interop.Excel.Application xlApp;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlApp = new Microsoft.Office.Interop.Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


             Screenshot().Save(@"C:\Users\v-tiguo\Downloads\jakeydocs\cc.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //Create a bitmap with the same dimensions like the screen
            Bitmap b = new Bitmap(@"C:\Users\v-tiguo\Downloads\jakeydocs\cc.jpg", true);
            Clipboard.SetDataObject(b);
            ////Microsoft.Office.Interop.Excel.Application thisApp   ;
            //Microsoft.Office.Interop.Excel.Application thisApp = new Microsoft.Office.Interop.Excel.Application();

            ////Excel.Application thisApp = 
            //Microsoft.Office.Interop.Excel.Worksheet sheet1 = thisApp.Workbooks.get_Item(1).Worksheets.get_Item(1) as Microsoft.Office.Interop.Excel.Worksheet;
            //Microsoft.Office.Interop.Excel.Range rng = sheet1.get_Range("A1:F40");
            //sheet1.Paste(rng, false);
            //thisApp.SaveAs("csharp.net-informations.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //thisApp.Close(true, misValue, misValue);
            //thisApp.Quit();

            return View();
        }
        private Bitmap Screenshot()
        {
            //Create a bitmap with the same dimensions like the screen
            Bitmap screen = new Bitmap(SystemInformation.VirtualScreen.Width,
        SystemInformation.VirtualScreen.Height);

            //Create graphics object from bitmap
            Graphics g = Graphics.FromImage(screen);

            //Paint the screen on the bitmap
            g.CopyFromScreen(SystemInformation.VirtualScreen.X,
        SystemInformation.VirtualScreen.Y,
        0, 0, screen.Size);
            g.Dispose();
          
            //return bitmap object / screenshot
            return screen;
        }

        // POST: MVC0119/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MVC0119/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: MVC0119/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
