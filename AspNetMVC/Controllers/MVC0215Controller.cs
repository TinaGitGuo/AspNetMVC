using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0215Controller : Controller
    {
        //[AlwaysFails(ErrorMessage = "Contact")]

        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        public class Contact
        {
            
            [Required]
            public string Name { get; set; }

            [Required]            
            public string PhoneNo { get; set; }

            [Required]            
            public string EmailAddress { get; set; }
            [Required]            
            public Address Address { get; set; }
        }

        
        public class Address
        {
            [Required]
            public string Province { get; set; }
            [Required]
            public string City { get; set; }
            [Required]
            public string District { get; set; }
            [Required]
            public string Street { get; set; }
        }
       
        //public ActionResult Index1()
        //{
        //    Address address = new Address
        //    {
        //        Province     = "江苏",
        //        City         = "苏州",
        //        District     = "工业园区",
        //        Street       = "星湖街328号"
        //    };
        //    Contact contact = new Contact
        //    {
        //        Name         = "张三",
        //        PhoneNo      = "123456789",
        //        EmailAddress = "zhangsan@gmail.com",
        //        Address      = address
        //    };
     
        //    return View(contact);
        //}
        public ActionResult Index1()
        {
            //DataTable a = db.Database..SqlQuery("").AsQueryable()  ;
                 
            return View( );
        }

        [HttpPost]
        public void Index1(Contact contact)
        {
            foreach (string key in ViewData.ModelState.Keys)
            {
                Response.Write(key + "<br/>");
                ModelState modelState = ViewData.ModelState[key];
                Response.Write(string.Format("&nbsp;&nbsp;&nbsp;&nbsp;Value: {0}<br/>", modelState.Value.ConvertTo(typeof(string))));
                foreach (ModelError error in modelState.Errors)
                {
                    Response.Write(string.Format("&nbsp;&nbsp;&nbsp;&nbsp;Error: {0}<br/>", error.ErrorMessage));
                }
            }
        }
        public bool ToGet(string str) {
            return true;
        }
        public void index3() {

            //db.BookMasters.Where(m => m.Id >= 1).Where(u => u.);
            db.BookMasters.Where(m=>ToGet(m.strAccessionId)).ToList();
            db.BookMasters.Where(m => true);
            //db.BookMasters.Select(u => { new List<string>() {
            //    int c=0;
            //    if (int.TryParse(u., out c))
            //    { //if it can covert to int type successfully
            //        if (int.Parse(e1) <= c && int.Parse(e2) >= c)
            //        {
            //            d.Add(b);
            //        }
            //    };


            //} });
               var c= db.Database.SqlQuery<BookMaster>("select * from BookMaster where column like '%u%'");

            //            return Find(m => m.CreatedDate >= startDate && m.CreatedDate <= endDate
            //&& m.Marc21Id == 15
            //&& m.Name != null
            //&& m.Name.StartsWith(startValue)
            //&& m.Name.EndsWith(endValue);
        }
        // GET: MVC0215
        public ActionResult Index()
        {

            string path=  Server.MapPath("~/Content/JOSN1.json");
            string str=   ForBytes.GetStringFromByte( ForBytes.GetByteData(path));
            int i=  str.IndexOf("CountryCode");
            int i1 = str.IndexOf("\"",i+14);
            string test1= str.Substring(i);
            string test2 = str.Substring(i1);
            str= str.Remove(i + 14, i1-(i+14));
            str=  str.Insert(i + 14,"IN");
            string a = "vbljadsflvnbaijdlfj654613213";
            int b = a.IndexOf('v');
            a = a.Remove(b, 1);
            string content = "这是中国一个中国二个中国";
            int aa= content.IndexOf("中国");
            content.IndexOf("中国",aa);
            //con
            Regex r1 = new Regex(@"中国");
            MatchCollection matchCollection = r1.Matches(content);
            foreach (Match m in matchCollection)
            {
                //m.Index
                    content.Substring(m.Index, 5);
                //content.Replace();
                Debug.WriteLine("m");
                //  将匹配出来的中国随机替换为世界,地球,宇宙,或不替换(根据随机数判断) , 不能将全部中国替换为一个词.
            }

            Debug.WriteLine("m");
            //string c = "abcdefghi";
            //c.IndexOfAny("county");
            //c.Substring("");
            return View();
        }

       
    }
}