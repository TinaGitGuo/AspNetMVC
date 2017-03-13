<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm0302.aspx.cs" Inherits="WebApplicationForm.WebForm0302" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        
        
    <div>
            <div>
            <script type="text/javascript">
                //treeview do postback
                function postBackByObject() {
                    var o = window.event.srcElement;
                    if (o.tagName == "INPUT" && o.type == "checkbox") {
                        __doPostBack("", "");
                    }
                }
            </script>

            <asp:TreeView ID="TVcolors" runat="server" 
                OnTreeNodeCheckChanged="TVcolors_TreeNodeCheckChanged" EnableClientScript="true" onclick="postBackByObject();"
                ExpandDepth="FullyExpand" ShowCheckBoxes="All">
                <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
                <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="2px"
                    NodeSpacing="0px" VerticalPadding="2px"></NodeStyle>
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px"
                    VerticalPadding="0px" />
                <Nodes>
                    <asp:TreeNode Text="Cars" Value="101">
                        <asp:TreeNode Text="Alto" Value="alto"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Bikes" Value="102">
                        <asp:TreeNode Text="Discover" Value="discover"></asp:TreeNode>
                        <asp:TreeNode Text="Avenger" Value="avenger"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>
        </div>


    </div>
    </form>
</body>
</html>
