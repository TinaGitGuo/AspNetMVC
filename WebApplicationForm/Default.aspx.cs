using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sFileImage = @"C:\Users\Administrator\Pictures\images\101.jpg";
           String sFilePath = @"C:\Users\Administrator\Pictures\images\101"+".xls";
            if (File.Exists(sFilePath)) { File.Delete(sFilePath); }

            ApplicationClass objApp = new ApplicationClass();
            Worksheet objSheet = new Worksheet();
            Workbook objWorkBook = null;
            //object missing = System.Reflection.Missing.Value;

            try
            {
                objWorkBook = objApp.Workbooks.Add(Type.Missing);
                objSheet = (Microsoft.Office.Interop.Excel.Worksheet)objWorkBook.ActiveSheet;

                //Add picture to single sheet1 
                objSheet = (Worksheet)objWorkBook.Sheets[1];
                objSheet.Name = "Graph with Report";

   //             ////////////// 

   //             //Or multiple sheets
            
   //for (int iSheet = 0; iSheet < objWorkBook.Sheets.Count - 1; iSheet++)
   //             {
   //                 objSheet = objWorkBook.Sheets[iSheet] as Worksheet;
   //                 ///(objSheet as Microsoft.Office.Interop.Excel._Worksheet).Activate();
   //             }

   //             /////////////////

                objSheet.Shapes.AddPicture(sFileImage, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 10, 10, 700, 350);
                objWorkBook.SaveAs(sFilePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception)
            {
                //Error Alert
            }
            finally
            {
                objApp.Quit();
                objWorkBook = null;
                objApp = null;
            }
        }
    }
}