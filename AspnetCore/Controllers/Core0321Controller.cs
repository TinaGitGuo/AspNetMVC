using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Xml;
using System.Net;
namespace AspnetCore.Controllers
{
    public class Core0321Controller : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            //Startup.connectionString = "FR";
            return View();
        }
        public IActionResult Index2()
        {

            string strUrl = "http://www.w3school.com.cn/example/xmle/note.xml";
            XmlDocument doc = new XmlDocument();
            //doc.BaseURI = strUrl;

            doc.LoadXml(strUrl);

            NewMethod();

            //System.Net.HttpWebResponse a=new HttpWebResponse ("");
            //a.ResponseUri();
            //string reply = client.DownloadString(address);
            return View();
        }

        private static void NewMethod()
        {
            //WebClient client = new WebClient();
        }

        public IActionResult Index3() {
            string a = "2.8,3.3";
            string a1 = "2.3";


            string[] b = a.Split(',');
            string[] b1 = a1.Split(',');

            string d = "0";
            if (b.Count() == 2) {
                d = b[1];
            }
            Console.Write(d);  //print 3.3
            string d1 = "0";
            if (b1.Count() == 2)
            {
                d1 = b1[1];
            }
            Console.Write(d1); ////print 0



            return View();

        }
        public IActionResult Index4() {
            //System.Data.SqlClient.SqlConnection vConn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);
            //vConn.Open();
            //String vQuery = "Select * from Employee";
            //SqlDataAdapter vAdap = new SqlDataAdapter(vQuery, vConn);
            //DataSet vDs = new DataSet();
            //vAdap.Fill(vDs, "Employee");
            //vConn.Close();
            //DataTable vDt = vDs.Tables[0];

           
            return View();
        }
    }
}