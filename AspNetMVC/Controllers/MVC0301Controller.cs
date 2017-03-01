
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0301Controller : Controller
    {
        // GET: MVC0301
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        public ActionResult Index()
        {
            SqlCommand cmd;
            SqlConnection con;
            //data source=VDI-V-TIGUO;initial catalog=CodeFirstDbDemo20;integrated security=True;" providerName="System.Data.SqlClient"
            con = new SqlConnection(@"data source=VDI-V-TIGUO;initial catalog=CodeFirstDbDemo;integrated security=True;"  );
            //con = new SqlConnection(@"Data Source=MyServer;Initial Catalog=MyDataBase;Integrated Security=True");
            cmd = new SqlCommand("sp_LoginUser", con);
            SqlParameter RetVal = cmd.Parameters.Add
   ("RetVal", SqlDbType.Int);
            RetVal.Direction = ParameterDirection.ReturnValue;
            //cmd = new SqlCommand("sp_getTreeById", con);
            
            cmd.CommandType = CommandType.StoredProcedure;         
            con.Open();
            cmd.ExecuteScalar() ;
            db.Database.SqlQuery<BookMaster>
                  ("SELECT   * FROM dbo.Posts WHERE Author = @author", new SqlParameter("@author", "authornamevalue"));
            //return Content(RetVal.Value.ToString() );
            return View();
        }
    }
}