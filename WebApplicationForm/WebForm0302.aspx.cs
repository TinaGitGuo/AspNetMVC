using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class WebForm0302 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TVcolors_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            List<string> childitemList = new List<string>();
            foreach (TreeNode tn in TVcolors.CheckedNodes)
            {
                //check whether it contains child node.
                if (tn.ChildNodes.Count == 0)
                {
                    childitemList.Add(tn.Value);
                }
            }

            //based on the checked child node values to filter the database 

            //then populate the other threeview

        }

    }
}