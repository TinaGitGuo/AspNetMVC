<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm0224.aspx.cs" Inherits="WebApplicationForm.WebForm0224" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<%--    <style>
        .boxright {
            float: left;
            height: 890px;
            margin: 0 auto;
            overflow: auto;
            padding: 10px 10px 10px 10px;
            background-color: rgba(0, 0, 255, 0.12);
        }

        .boxright div:hover {
            transform: scale(1.01);
            box-shadow: 1px 1px 5px 0px #777;
            border-radius:5px;
        }

        .boxright_active {
            transform: scale(1.01);
            box-shadow: 1px 1px 10px 0px #777;
            border-radius:5px;
        }

        .boxright div:active {
            transform: scale(1.01);
            box-shadow: 1px 1px 10px 0px #777;
            border-radius:5px;
        }

        .boxleft {
            float: left;
            margin: 0 auto;
            padding: 15px;
            overflow: hidden;
        }
    </style>--%>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<%--        <asp:UpdatePanel ID="UpdatePanel2" runat="server"></asp:UpdatePanel>--%> UpdateMode="Conditional"  ChildrenAsTriggers="true"
    <div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>
            <div class="VDOContainer raw">
                <div class="vdoname" id="area" runat="server">
                    <asp:Label ID="VDOName" runat="server" CssClass="vdofonthead" Text="Video Name"></asp:Label>
                </div>

                <div class="boxleft col-lg-8 col-md-8 col-sm-12">
                    <asp:Literal ID="lblvedio" runat="server"></asp:Literal>
                    <ul class="raw like-section">
                        <li class="col-md-6 like-btn">
                            <asp:Button ID="btn_Like" runat="server" Text="Like" CssClass="btn btn-outline btn-lg"></asp:Button>
                            <div class="btn btn-lg" style="cursor:default;">
                                <%--<img class="vlike" src="img/like.png" alt="like image" />--%>
                                <asp:Label ID="lblLike" runat="server"></asp:Label>
                            </div>
                            <div class="btn btn-lg" style="cursor:default;">
                                <%--<img class="vlike" src="img/like.png" alt="like image" />--%>
                                <asp:Label ID="lblView" runat="server"></asp:Label>
                                Views
                            </div>
                        </li>
                    </ul>
                    <div class="vdoname" id="Div1" runat="server">
                        <asp:Label ID="VDODesc" runat="server" CssClass="vdofonthead" Text="Video Description"></asp:Label>
                    </div>
                </div>
  OnSelectedIndexChanged="listviedo_SelectedIndexChanged"
                       
                <div class="boxright col-lg-4 col-md-4 col-sm-12">
                    <asp:ListView runat="server" OnSelectedIndexChanging="listviedo_SelectedIndexChanging" ID="listviedo"
                      
                        SelectedIndex="0"  ClientIDMode="AutoID"  >
                        <ItemTemplate>
                            <asp:Panel runat="server" ID="selected_panel1" >
                                <div class="vdofont">
                                    <asp:LinkButton runat="server" ID="linkbtn" CommandName="Select"><%-- CommandArgument='<%# Eval("ID") %>'--%>
                                      <%--  <asp:Label ID="lblname" runat="server" Text='<%# Eval("VideoName")%>'></asp:Label>
                                        <asp:Label ID="lblid" runat="server" Visible="false" Text='<%# Eval("ID")%>'></asp:Label>--%>

                                        aaaa vvvvvvvvvvvvvvv   <%# Eval("col1")%>
                                    </asp:LinkButton>
                                </div>
                            </asp:Panel>
                        </ItemTemplate>                    
                        <SelectedItemTemplate>
                            <asp:Panel runat="server" ID="selected_panel" CssClass="boxright_active" BackColor="SkyBlue"> 
                                <div class="vdofont boxright_active">
                                    <asp:LinkButton runat="server" ID="linkbtn1" CommandName="Select" > bbbb <%# Eval("col1")%>
                                    </asp:LinkButton>
                                </div>
                            </asp:Panel>
                         </SelectedItemTemplate>
                    </asp:ListView><%--CommandArgument='<%# Eval("ID") %>'--%>
                                      <%--  <asp:Label ID="lblname" runat="server" Text='<%# Eval("VideoName")%>'></asp:Label>
                                        <asp:Label ID="lblid" runat="server" Visible="false" Text='<%# Eval("VID")%>'></asp:Label>--%>
                                      
                  <%--  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CodeFirstDbDemoConnectionString %>" SelectCommand="SELECT * FROM [BookMasters]"></asp:SqlDataSource>
                    <asp:EntityDataSource ID="EntityDataSource1" runat="server">
                    </asp:EntityDataSource>--%>
                </div>
            </div>

        </ContentTemplate>
        <Triggers>
          
          
           
        </Triggers>
    </asp:UpdatePanel><%--  <asp:AsyncPostBackTrigger ControlID="listviedo" EventName="ItemCommand" />  <asp:AsyncPostBackTrigger ControlID="listviedo" EventName="SelectedIndexChanged" /> <asp:AsyncPostBackTrigger ControlID="listviedo" EventName="SelectedIndexChanging" />--%>
    </div>
    </form>
</body>
</html>
