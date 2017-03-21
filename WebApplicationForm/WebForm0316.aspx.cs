using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplicationForm
{
    public partial class WebForm0316 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) {
                
                    string FilePath = Server.MapPath("./") + "Pictures";
                //获取上传图片的集合
                HttpFileCollection HFC = Request.Files;
                for (int i = 0; i < HFC.Count; i++)
                {
                    HttpPostedFile UserHPF = HFC[i];
                    if (UserHPF.ContentLength > 0)
                    {
                        // 获取上传图片的文件名
                        string fileName = UserHPF.FileName.Substring(UserHPF.FileName.LastIndexOf("\\"));
                        string pathes = FilePath + "\\" + System.IO.Path.GetFileName(UserHPF.FileName);
                        if (!Directory.Exists(FilePath))
                            Directory.CreateDirectory(FilePath);
                        //保存图片到指定的位置
                        UserHPF.SaveAs(pathes);


                        Bitmap image = new Bitmap(UserHPF.InputStream);

                        Bitmap target = new Bitmap(50, 50);

                        string pathesSmall = FilePath + "\\smail\\" + System.IO.Path.GetFileName(UserHPF.FileName);
                        Graphics graphic = Graphics.FromImage(target);
                        graphic.DrawImage(image, 0, 0, 50, 50);

                        if (!Directory.Exists(FilePath + "\\smail"))
                            Directory.CreateDirectory(FilePath + "\\smail");
                        target.Save(pathesSmall);

                      
                    }
                }
            }
        }

        //private void AddFileUpload()
        //{
        //    //定义数组
        //    ArrayList arrayList = new ArrayList();
        //    //清除Table中的行
        //    tab_FileUpload_Area.Rows.Clear();
        //    //调用自定义方法，获取上传文件控件集
        //    GetFileUpload();
        //    HtmlTableRow tabRow = new HtmlTableRow();
        //    HtmlTableCell tabCell = new HtmlTableCell();
        //    //添加上传控件
        //    tabCell.Controls.Add(new FileUpload());
        //    tabRow.Controls.Add(tabCell);
        //    tab_FileUpload_Area.Rows.Add(tabRow);
        //    //调用自定义方法，保存控件集信息到缓存中
        //    SetFileUpload();
        //}
        //// 获取缓存中上传文件控件集
        //private void GetFileUpload()
        //{
        //    //声明数组对象
        //    ArrayList arrayList = new ArrayList();
        //    if (Session["FilesControls"] != null)
        //    {
        //        //将生成的上传控件，显示在Table表格中
        //        arrayList = (System.Collections.ArrayList)Session["FilesControls"];
        //        for (int i = 0; i < arrayList.Count; i++)
        //        {
        //            HtmlTableRow tabRow = new HtmlTableRow();
        //            HtmlTableCell tabCell = new HtmlTableCell();
        //            tabCell.Controls.Add((System.Web.UI.WebControls.FileUpload)arrayList[i]);
        //            tabRow.Controls.Add(tabCell);
        //            tab_FileUpload_Area.Rows.Add(tabRow);
        //        }
        //    }
        //}
        //// 保存当前页面上传文件控件集到缓存中
        //private void SetFileUpload()
        //{
        //    //创建动态数组
        //    ArrayList arrayList = new ArrayList();
        //    foreach (Control C in tab_FileUpload_Area.Controls)
        //    {
        //        //判断控件类型
        //        if (C.GetType().ToString() == "System.Web.UI.HtmlControls.HtmlTableRow")
        //        {
        //            HtmlTableCell tabCell = (HtmlTableCell)C.Controls[0];
        //            //在Table单元格中检索FileUpload控件
        //            foreach (Control control in tabCell.Controls)
        //            {
        //                //判断控件类型
        //                if (control.GetType().ToString() == "System.Web.UI.WebControls.FileUpload")
        //                {
        //                    //将FileUpload控件信息保存到ArrayList控件中
        //                    FileUpload f = (FileUpload)control;
        //                    arrayList.Add(f);
        //                }//CodeGo.net/
        //            }
        //        }
        //    }
        //    Session.Add("FilesControls", arrayList);
        //}
        ////添加上传图片按钮
        //protected void imgBtnAdd_Click(object sender, ImageClickEventArgs e)
        //{
        //    this.AddFileUpload();
        //}
        ////多图片上传
        //protected void imgBtnUploadPic_Click(object sender, ImageClickEventArgs e)
        //{
        //    //设置上传图片保存的路径
        //    string FilePath = Server.MapPath("./") + "Pictures";
        //    //获取上传图片的集合
        //    HttpFileCollection HFC = Request.Files;
        //    for (int i = 0; i < HFC.Count; i++)
        //    {
        //        HttpPostedFile UserHPF = HFC[i];
        //        if (UserHPF.ContentLength > 0)
        //        {
        //            // 获取上传图片的文件名
        //            String fileName = UserHPF.FileName.Substring(UserHPF.FileName.LastIndexOf("\\"));
        //            //保存图片到指定的位置
        //            UserHPF.SaveAs(FilePath + "\\" + System.IO.Path.GetFileName(UserHPF.FileName));
        //            //如果上传图片为1张，则不按编号进行命名，如果为多张图片上传，则进行按编号命名。
        //            if (UserHPF.ContentLength == 1)
        //                imgData.AddNode(txtPicName.Text.Trim(), "Pictures" + fileName, "0", ViewState["ImgID"].ToString());
        //            else
        //                imgData.AddNode(txtPicName.Text.Trim() + i.ToString(), "Pictures" + fileName, "0", ViewState["ImgID"].ToString());
        //        }
        //    }
        //    //删除所有的FileUpload控件
        //    if (Session["FilesControls"] != null)
        //    {
        //        Session.Remove("FilesControls");
        //    }
        //}
    }
}