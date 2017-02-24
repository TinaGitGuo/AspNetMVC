//using AspNetMVC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class WebForm0224 : System.Web.UI.Page
    {
        //CodeFirstDbDemoEntities DB = new CodeFirstDbDemoEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void listviedo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Literal lblvedio = (Literal)e.Item.FindControl("lblvedio");
            Label lblname = (Label)e.Item.FindControl("lblname");
            if (e.CommandName == "Select")
            {
                int ID = Convert.ToInt32(e.CommandArgument);
                //Database.Tbl obj = DB.BookMasters.Single(p => p.Id == ID);
                //if (obj.IsUrl == false)
                //{
                //    string Link = "<iframe></iframe>";
                //}
                //else
                //{
                    string Link = "<iframe></iframe>";
                //}
            }
            if (e.CommandName == "Resume")
            {
                int ID = Convert.ToInt32(e.CommandArgument);
                //Database.Tbl objcar = DB.Tbl.Single(p => p.VID == ID);
            }
        }
        protected void listviedo_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            
            Label lblid = (Label)e.Item.FindControl("lblid");
            LinkButton linkresuume = (LinkButton)e.Item.FindControl("linkresuume");
            int ID = Convert.ToInt32(lblid.Text);
            //Database.Tbl objcar = DB.Tbl.Single(p => p.VID == ID);
        }
        protected void listviedo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Session["USER"] == null)
            //{
            //    Response.Redirect("Login");
            //}
            //else
            //{
                if (listviedo.SelectedIndex >= 0)
                {
                    int id1 = Convert.ToInt32(listviedo.SelectedValue.ToString());
                    lblvedio.Text = getvalue(id1);
                    //VDOName.Text = getName(id1);
                    //VDODesc.Text = getDesc(id1);
                    //lblView.Text = getView(id1).ToString();
                    //lblLike.Text = getLike(id1).ToString();
                }
            //}
        }

        private string getvalue(int id1)
        {
            return id1.ToString();
        }

        protected void listviedo_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
            this.listviedo.SelectedIndex = e.NewSelectedIndex;
        }
    }
}