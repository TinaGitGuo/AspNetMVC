using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class WebForm0228 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Butremove.Visible = false;
        }

        protected void ButAdd_Click(object sender, EventArgs e)
        {
            Button tb = (Button)sender;
            tb.Visible = false;
            //ButAdd.Visible = false;
            Butremove.Visible = true;
        }
    }
}