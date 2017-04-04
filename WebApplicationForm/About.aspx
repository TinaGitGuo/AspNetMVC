<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplicationForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">  
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
          
<asp:ImageButton runat="server" ImageUrl="~/Content/u=2317499888,864114656&amp;fm=23&amp;gp=0.jpg" OnClick="Unnamed1_Click" OnClientClick="Confirm()" ></asp:ImageButton>
            <asp:GridView ID="GridView1" runat="server" OnDataBinding="GridView1_DataBinding">
            </asp:GridView> <asp:Button ID="Button1" runat="server" Text="Button" />
        </ContentTemplate>
      
</asp:UpdatePanel>  <script src="Content/JavaScript.js"></script>
    <script>
     
    </script>
</asp:Content>
