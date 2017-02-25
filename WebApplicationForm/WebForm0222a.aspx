<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm0222a.aspx.cs" Inherits="WebApplicationForm.WebForm0222a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:TreeView ID="TreeView1" runat="server" ShowCheckBoxes="All">
    <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
    <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="2px"
        NodeSpacing="0px" VerticalPadding="2px"></NodeStyle>
    <ParentNodeStyle Font-Bold="False" />
    <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px"
        VerticalPadding="0px" />
           
</asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <%--<asp:TextBox ID="alcup1" runat="server"></asp:TextBox>--%>
       <%-- <asp:TextBox TextMode="Number" ID="alcup1" runat="server" ClientIDMode="Static" Height="20px" Width="60px" min="-45"max="45" onwheel="alcupFunction()" onkeyup="alcupFunction()" onkeydown="alcupFunction()" onchange="alcupFunction()"></asp:TextBox>--%>
            <asp:TextBox  ID="alcup1"  TextMode="Number" ClientIDMode="Static" runat="server" Height="20px" Width="60px" min="-45" max="45"  onwheel="alcupFunction()" onkeyup="alcupFunction()" onkeydown="alcupFunction()" onchange="alcupFunction()" ></asp:TextBox>
<script> 
    function alcupFunction(controlname)
    {
        var num = document.getElementById('<%=alcup1.ClientID %>').value;
     <%--   if (document.getElementById('<%=RepeaterPwr1.ClientID %>').value == 10)
        {--%>
            if (num < -12)
            {
                document.getElementById('<%=alcup1.ClientID %>').value = -12;
                document.getElementById('<%=alcup1.ClientID %>').focus();
                return false;
            }
            if (num > 12)
            {
                document.getElementById('<%=alcup1.ClientID %>').value = 12;
                document.getElementById('<%=alcup1.ClientID %>').focus();
                return false;
            }
        //}
        return true;
    }

</script>
    </div>
    </form>
</body>
</html>
