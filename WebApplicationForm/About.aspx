<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplicationForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <img src="Content/chongwu1110.jpg" />
    <input type="text" id="oo"/>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="Confirm()" ImageUrl="~/Content/chongwu1110.jpg" />
    <p>Use this area to provide additional information.</p>

    <script>
        function Confirm() {
            var confirm_value = document.createElement("INPUT");

            confirm_value.type = "text";
            confirm_value.name = "confirm_value";

            if (confirm("Are You Sure You Want To Remove This Meeting Note?")) {
                confirm_value.value = "Yes";
            }
            else {
                confirm_value.value = "No";
            }
            document.getElementById("oo").value = "1111";
            document.forms[0].appendChild(confirm_value);
        }

        var para = document.createElement("p");
        var node = document.createTextNode("这是新段落。");
        para.appendChild(node);

       
        //document.forms.appendChild.appendChild(para);
    </script>
</asp:Content>
