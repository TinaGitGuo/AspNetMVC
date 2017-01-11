using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class About : Page
    {
        private int _AccessLevel;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                string confirmValue = Request.Form["confirm_value"];

                if (confirmValue == "Yes")
                {
                    //if (_AccessLevel == 1)
                    //{
                    //    _Success = SQL_Functions.DeleteMeetingNotes(Convert.ToInt64(Session["_DateID"]));
                    //    if (_Success == true)
                    //    {
                    //        MessageBox("Your Meeting Note Has Been Removed!");
                    //        _LastIndex = 0;
                    //        Build_MeetingNotes();
                    //    }
                    //    else
                    //    {
                    //        MessageBox("Failed To Delete The Meeting Note!");
                    //    }
                    //}
                    //else
                    {
                        //MessageBox("Access Denied");
                    }
                }
                else
                {
                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked NO!')", true);
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void GridView1_DataBinding(object sender, EventArgs e)
        {
            var data=new DataTable();
            if (data== null)
            {
                GridView1.Columns[2].Visible = false;
                Button1.Visible = false;
            }
            else
            {
                data = new List<Product>();
                
            }
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}