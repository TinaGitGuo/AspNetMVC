using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class WebForm0222a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //    SqlConnection con = new SqlConnection("Data Source=  ; initial catalog= Northwind ; User Id=  ; Password=  '");

            //    con.Open();
            //    SqlCommand command = new SqlCommand("RegionUpdate", con);


            //    command.CommandType = CommandType.StoredProcedure;

            //    command.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int, 0, "RegionID"));

            //    command.Parameters.Add(new SqlParameter("@RegionDescription", SqlDbType.NChar, 50, "RegionDescription"));


            //    command.Parameters[0].Value = 4;

            //    command.Parameters[1].Value = "SouthEast";

            //    int i = command.ExecuteNonQuery();
        }
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private object userName;

        public  DataTable ExecuteProduce() {
            con = new SqlConnection(@"Data Source=MyServer;Initial Catalog=MyDataBase;Integrated Security=True");
            con.Open();
            cmd= new SqlCommand("LoginUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = Query;
            //cmd.Connection = con;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value= "userName";
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 20).Value= "pwd";
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);    
            cmd.ExecuteNonQuery();          
            con.Close();
            return dt;
            //////////////////////

            //dt = new DataTable();
            //SqlConnection con = new SqlConnection(@"Data Source=MyServer;Initial Catalog=MyDataBase;Integrated Security=True");
            //cmd.CommandText = spName;
            //cmd.Connection = con;

            //cmd.CommandType = CommandType.StoredProcedure;
            //var name = cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20);
            //var pwd = cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 20);
            //name.Value = userName;
            //pwd.Value = pwd;

            //da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //return dt;

        }
    }
}