using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class WebForm0216 : System.Web.UI.Page
    {
        

        int flag = 1;
        SqlConnection con = new SqlConnection("Data Source=INSPIRE-1;Initial Catalog=new;Integrated Security=True");
        public static int parent = 0;
        int[] a = new int[50];

        Panel pnlDropDownList;
        protected void Page_PreInit(object sender, EventArgs e)
        {

            //Create a Dynamic Panel
            pnlDropDownList = new Panel();
            pnlDropDownList.ID = "pnlDropDownList";
            pnlDropDownList.BorderWidth = 1;
            pnlDropDownList.Width = 300;
            this.form1.Controls.Add(pnlDropDownList);

        }
        protected void Page_Load(object sender, EventArgs e)
        {



            //string[] arr1 = new string[10];

            //Session["myarray"] = arr1;
            // Session["ddl"]= Session["myarray"][0];

            //OnSelectedIndexChanged(sender, e);
            //  UpdatePanel updatePanel = new UpdatePanel();
            //  updatePanel.UpdateMode = UpdatePanelUpdateMode.Conditional;
            //  updatePanel.ID = "UpdatePanel1";

            //  updatePanel.ContentTemplateContainer.Controls.Add(ddl);
            //  updatePanel.ContentTemplateContainer.Controls.Add(ddl);

            //  AsyncPostBackTrigger trigger = new AsyncPostBackTrigger();
            //  trigger.ControlID = ddl.ClientID;
            //  trigger.EventName = "OnSelectedIndexChanged";

            //  updatePanel.Triggers.Add(trigger);

            //  this.Page.Form.Controls.Add(updatePanel);
            //int[,] array6 = new int[10, 10];
            Hashtable asd = new Hashtable();

            int cnt =FindOccurence("ddlDynamic");
            if (cnt == 0)
            {
                //a[cnt + 1] =1; //a[1]=0;
                Session["parents"] = a;
                CreateDropDownList("ddlDynamic-" + Convert.ToString(cnt + 1), a[cnt + 1]);//CreateDropDownList("ddlDynamic-1",0);a[1]=0;
            }
            else { 
            RecreateControls("ddlDynamic", "DropDownList");
            }
            if (flag == 1)
            {

                flag = 0;
            }

        }

        private int FindOccurence(string substr)
        {
             //return 2;
            string reqstr = Request.Form.ToString();

            return ((reqstr.Length - reqstr.Replace(substr, "").Length) / substr.Length);
        }
        private void RecreateControls(string ctrlPrefix, string ctrlType)
        {


            DropDownList ddl = new DropDownList();
           // ddl.ID = ID;//ID :_Page
            ddl.ID = "ddlDynamic-1";
            int value = 1;
            string[] ctrls = Request.Form.ToString().Split('&');
            int cnt = FindOccurence(ctrlPrefix);
             a = (int[])Session["parents"];//a awalays 0


            if (cnt > 0)
            {
                for (int k = 1; k <= cnt; k++)
                {
                    for (int i = 0; i < ctrls.Length; i++)
                    {
                        if (ctrls[i].Contains(ctrlPrefix + "-" + k.ToString()) && !ctrls[i].Contains("EVENTTARGET"))
                        {
                            string ctrlID = ctrls[i].Split('=')[0];
                            int b = Convert.ToInt32(ctrlID.Split('-')[1]);
                            int c = Convert.ToInt32(Session["ddl"]);
                            //if (b > c)
                            //{
                            //    break;
                            //}
                            //else
                            //{
                                //if (ctrlType == "DropDownList")
                                //{

                                    CreateDropDownList(ctrlID, a[value]);
                                    //value++;

                                //}
                            //}
                            break;
                        }
                    }
                }

            }

        }

        private void CreateDropDownList(string ID, int parent)//ID:ddlDynamic-1 parent:0
        {

            //con.Open();
            SqlDataAdapter abc;
            //if (parent == 0)
            //{
                abc = new SqlDataAdapter("select catid,name from catgry where parent =" + parent, con);//
            //}

            //else
            //{
            //    abc = new SqlDataAdapter("select catid,name from catgry where parent=" + parent, con);
            //}


            DropDownList ddl = new DropDownList();
            ddl.ID = ID;
            //DataTable b = new DataTable();
            //abc.Fill(b);
            //if (b.Rows.Count != 0)
            //{
            //ddl.DataSource = b;
            //ddl.DataTextField = "name";
            //ddl.DataValueField = "catid";
            //ddl.DataBind();
              ddl.Items.Add(new ListItem("1", "1"));
            ddl.Items.Add(new ListItem("2", "2"));
            ddl.Items.Add(new ListItem("3", "3"));
            ddl.Items.Add(new ListItem("4", "4"));
            ddl.Items.Insert(0, new ListItem("Select Category", "0"));
               // con.Close();
                ddl.AutoPostBack = true;

                ddl.SelectedIndexChanged += new EventHandler(ddl_OnSelectedIndexChanged);


                pnlDropDownList.Controls.Add(ddl);
                Literal lt = new Literal();
                lt.Text = "<br />abc";
                pnlDropDownList.Controls.Add(lt);



            //}

        }
        protected void ddl_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            string ID = ddl.ID;
            //  int[,] array6 = new int[10, 10];
            // string[] arr1 = new string[10];
            //  Session["myarray"] = arr1;

            //Session["ddl"] = ddl.ID;

            Session["ddl"] = ddl.ID.Split('-')[1];
            int cnt = FindOccurence("ddlDynamic");
            //int[] a = (int[])Session["parents"];
             a = (int[])Session["parents"];
            a[cnt] = int.Parse(ddl.SelectedValue);
            Session["parents"] = a;
            CreateDropDownList("ddlDynamic-" + Convert.ToString(cnt), a[cnt]);
            //ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", "<script type = 'text/javascript'>alert('" + ID + " fired SelectedIndexChanged event');</script>");
            //parent = Convert.ToInt32(ddl.SelectedValue);

        }

    }
}