using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMVC;
using System.Runtime.Serialization;
using System.IO;
using static AspNetMVC.Controllers.MVC0112Controller.Customers;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Mail;
using System.Threading.Tasks;

namespace AspNetMVC.Controllers
{
    public class MVC0112Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        private System.Net.Mail.MailMessage objMailMessage;

        public class Customers
        {
            [DataContract]
            public class ExtData
            {
                [DataMember]
                public List<object> videos { get; set; }
            }

            [DataContract]
            //[KnownType(typeof( Customers))]
            public class RootParent
            {
                [DataMember]
                public string name { get; set; }
                [DataMember]
                public Sites site { get; set; }
            }
            public class Sites
            {
                public int SitesID { get; set; }
            }


        }
        // GET: MVC0112
        public ActionResult Index()
        {
            Customers customers = new Customers() { };
            RootParent rootParent = new RootParent() { name = "name", site = new Sites() { SitesID = 1 } };
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer dcs = new DataContractJsonSerializer(typeof(RootParent));

            dcs.WriteObject(ms, rootParent); // Note: rootParent is an instance, which i'm using to assign data to. Its this line the program crashes on
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            string json = sr.ReadToEnd();

            //stream1.Position = 0;
            return View(db.BookMasters.ToList());
        }
        public class NewsModels
        {
            public List<ArticleDetails> entryList = new List<ArticleDetails>();

        }


        public class ArticleDetails
        {

            public string id { get; set; }
            public string updated { get; set; }
            public string published { get; set; }
            public string title { get; set; }
            public string summary { get; set; }

        }
        public async  Task<ActionResult> Index3()
        {
            //LoadImage.GetByteData()
            NewsModels objNews = new NewsModels() { entryList=new List<ArticleDetails>() { new ArticleDetails() { id="2" } } };
            using (var client = new HttpClient())
            {
                
                string url = string.Format("http://export.arxiv.org/api/query?search_query=ti:{0}&sortBy=lastUpdatedDate&sortOrder=descending", Server.UrlEncode("\"quantum simulator\""));
                var uri = new Uri(url);
               
               string getxml=await client.GetStringAsync(uri);
                var deserializer = new System.Xml.Serialization.XmlSerializer(typeof(ArticleDetails));
                 var xmlReader = System.Xml.XmlReader.Create(uri.ToString());
                //var xmlReader = System.Xml.XmlReader.Create(getxml);
               
                var obj = (ArticleDetails)deserializer.Deserialize(ForBytes.GetStreamFromBytes( ForBytes.GetByteFromString( getxml)));


                return  View("Index", obj);
            }
        }
        // GET: MVC0112/Details/5
        public ActionResult Details(int? id)
        {
            //IfxConnection
            //         IfxConnection(myConnectionString)
            //Dim myInsertQuery As String = "INSERT INTO STAFF (ID, NAME) Values(...)"
            //Dim myIfxCommand As New IfxCommand(myInsertQuery)
            //myIfxCommand.Connection = myConn
            //myConn.Open()
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

        // GET: MVC0112/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVC0112/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,strBookTypeId,strAccessionId")] BookMaster bookMaster, FormCollection collection)
        {
            string[] userIds = collection.GetValues("userId");

            if (userIds != null)// collection.GetValues("userId") value is string array ,such as  { "1", "2" };
            {
                foreach(string userid in userIds)
                {
                    BookMaster bookmaster = db.BookMasters.Find(userIds);
                    System.Web.Mail.MailMessage objMailMessage = new System.Web.Mail.MailMessage();
                    objMailMessage.From = "scucj@sina.com";
                    objMailMessage.To = "mygoogle@gmail.com";
                    objMailMessage.Subject = "my subject:hello";
                    objMailMessage.Body = "test data";
                    objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                    //username 
                    objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "username");//bookmaster.username
                    //password 
                    objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "password");//bookmaster.password
                    //SMTPaddress
                    SmtpMail.SmtpServer = "smtp.sina.com.cn";
                    //开始发送邮件 
                    SmtpMail.Send(objMailMessage);
                }
            
            }
            return View(bookMaster);
        }
        
        // GET: MVC0112/Edit/5
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

        // POST: MVC0112/Edit/5
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

        // GET: MVC0112/Delete/5
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

        // POST: MVC0112/Delete/5
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
