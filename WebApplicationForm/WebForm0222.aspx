<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm0222.aspx.cs" Inherits="WebApplicationForm.WebForm0222" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1"  RowStyle-Font-Bold="false" BorderStyle="None" CellPadding="0" GridLines ="None" ItemStyle-VerticalAlign="Middle">
            <Columns>
                <asp:TemplateField HeaderText="    Table" InsertVisible="False"> 
<ItemTemplate> 
<%#Container.DataItemIndex+1%> 
</ItemTemplate> 
</asp:TemplateField> 
                <asp:BoundField DataField="Id" HeaderText=" " InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="strBookTypeId" HeaderText=" " SortExpression="strBookTypeId" />
                <asp:BoundField DataField="strAccessionId" HeaderText=" " SortExpression="strAccessionId" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CodeFirstDbDemoConnectionString %>" SelectCommand="SELECT * FROM [BookMasters]"></asp:SqlDataSource>
     
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1"   RowStyle-Font-Bold="false" BorderStyle="None" CellPadding="0" GridLines ="None" ItemStyle-VerticalAlign="Middle" >
            <Columns>
                    <asp:TemplateField HeaderText="    Table1" InsertVisible="False"> 
<ItemTemplate> 
     
<%#this.GridView1.Rows.Count+ Container.DataItemIndex+1%> 
  <asp:Label ID="Label2" runat="server" Text='<%# int.Parse( Bind("Id"))*int.Parse(Bind("Id")) %>'></asp:Label>

</ItemTemplate> 
</asp:TemplateField> 
                <asp:BoundField DataField="Id" HeaderText=" " InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="strBookTypeId" HeaderText=" " SortExpression="strBookTypeId" />
                <asp:BoundField DataField="strAccessionId" HeaderText=" " SortExpression="strAccessionId" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
