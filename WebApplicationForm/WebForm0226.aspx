<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm0226.aspx.cs" Inherits="WebApplicationForm.WebForm0226" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> DataKeyNames="ProductCategoryID"
    <asp:ListView runat="server" 
        ID="listviedo"
       OnItemDeleting="CategoriesListView_OnItemDeleting"
       DataKeyNames="col1" OnItemUpdating="listviedo_ItemUpdating" OnSelectedIndexChanged="listviedo_SelectedIndexChanged" OnSelectedIndexChanging="listviedo_SelectedIndexChanging"
       >
        <LayoutTemplate>
          <table runat="server" id="tblCategories" 
                 cellspacing="0" cellpadding="1" width="440px" border="1">
            <tr id="itemPlaceholder" runat="server"></tr>
          </table>
        </LayoutTemplate>
        <ItemTemplate>
          <tr runat="server">
            <td>
              <asp:Label runat="server" ID="NameLabel" Text='<%#Eval("col1") %>' />
            </td>
            <td style="width:40px">
              <asp:LinkButton runat="server" ID="SelectCategoryButton" 
                Text="Select" CommandName="Select" />
            </td>
          </tr>
        </ItemTemplate>
        <SelectedItemTemplate>
          <tr runat="server" style="background-color:#90EE90">
            <td>
              <asp:Label runat="server" ID="NameLabel" Text='<%#Eval("col1") %>' />
            </td>
            <td style="width:40px">
              <asp:LinkButton runat="server" ID="SelectCategoryButton" 
                Text="Delete" CommandName="Delete" />
            </td>
          </tr>
        </SelectedItemTemplate>
      </asp:ListView>
    </div>
    </form>
</body>
</html>
