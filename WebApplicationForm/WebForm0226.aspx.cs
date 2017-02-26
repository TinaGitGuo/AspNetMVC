using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class WebForm0226 : System.Web.UI.Page
    {
        protected void CategoriesListView_OnItemDeleting(object sender, ListViewDeleteEventArgs e)
        {
            //if (SubCategoriesGridView.Rows.Count > 0)
            //{
            //    MessageLabel.Text = "You cannot delete a category that has sub-categories.";
            //    e.Cancel = true;
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DataTable dt = new DataTable();
                DataColumn dc = new DataColumn("col1", typeof(String));
                dt.Columns.Add(dc);

                //dc = new DataColumn("col2", typeof(String));
                //dt.Columns.Add(dc);

                //dc = new DataColumn("col3", typeof(String));
                //dt.Columns.Add(dc);

                //dc = new DataColumn("col4", typeof(String));
                //dt.Columns.Add(dc);

                for (int i = 0; i < 5; i++)
                {
                    DataRow dr = dt.NewRow();

                    dr[0] = "coldata1" + i.ToString();
                    //dr[1] = "coldata2";
                    //dr[2] = "coldata3";
                    //dr[3] = "coldata4";

                    dt.Rows.Add(dr);
                }
                listviedo.DataSource = dt;
                listviedo.DataBind();
            }
        }

        protected void listviedo_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
            this.listviedo.SelectedIndex = e.NewSelectedIndex;
            //ListViewDataItem item = (ListViewDataItem)sender;
            this.listviedo.UpdateItem(e.NewSelectedIndex, false);
            //this.listviedo.ItemUpdating 
            //ListView.UpdateItem m
            //// Update the database with the changes.
            //VendorsListView.UpdateItem(item.DisplayIndex, false);
        }

        protected void listviedo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listviedo.UpdateItem( listviedo.SelectedIndex, false);
        }

        protected void listviedo_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            //listviedo.UpdateItem(listviedo.SelectedIndex, false);

        }
    }
}