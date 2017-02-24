using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;

using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Data;

namespace AspNetMVC.Controllers
{
    public class MVC0223Controller : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0223
        public ActionResult Index()
        {
            (from c in db.BookMasters select c.Id).Union(from e in db.BookMasters where e.Id>1 select e.Id);

          var str=  from a in db.BookMasters
            join b in db.BookMasters 
            on a.Id equals b.Id where b.Id>1
            select new { a.Id, b.strAccessionId };
            var q = from c in db.BookMasters where SqlMethods.Like(c.strAccessionId, "C%") select c ;
            db.sp_getTreeById(1);
            //            db.Database.ExecuteSqlCommand(
            //"UPDATE dbo.Posts SET Title = 'Updated Title' WHERE PostID = 99");
            //SqlCommand command = new SqlCommand(commandText, connection);
            //command..ExecuteNonQuery();

            //command.Parameters.Add("@ID", SqlDbType.Int);
            //command.Parameters["@ID"].Value = customerID;
            //db.BookMasters.GroupJoin(a,m=>m.)
            return View();
        }
    }
}