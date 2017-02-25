<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm0223.aspx.cs" Inherits="WebApplicationForm.WebForm0223" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <br /><br /><br /><br /><br />
    <asp:Panel ID="PanelReset" runat="server" Visible="true">
        <table style="margin:0 auto">
            <tr>
                <td> <table style="padding: 1px; border-style:none; background-color:#E0E0E0; border-color:#FF9900;border-width: 2px;">
                        <tr>
                            <td>
                                <table style="padding: 0px">
                                    <tr>
                                        <td colspan="2" style="text-align: center; color:White; background-color:#FF9933;font-weight:bold;height:20px;white-space:nowrap; vertical-align: middle;">VIS</td>
                                    </tr>
                                    <tr>
                                        <td colspan="0" >&nbsp;</td>
                                    </tr>
                                     <tr>
                                        <td >  
                                         <div style="display: inline inline-block; padding: 1px 2px 12px; vertical-align:middle;text-align: center;"    >
                                            
              bbb<%--<telerik:RadAsyncUpload ID="RadAsyncUpload1" runat="server" MaxFileInputsCount="01" MaxFileSize="1145728" 
              AllowedFileExtensions=".csv,.xls,.xlsx"  ></telerik:RadAsyncUpload>--%>aa

         </div>
                                        
                                        </td>
                                       
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                   
                                    
                                    <tr>
                                        <td colspan="2" style="color:Red; text-align: center;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                 
                                    <tr>
                                        <td colspan="2" style="text-align: center;" class="auto-style1">
                                            <asp:Button ID="PassButton" runat="server" Text="Select File"  Width="120px" />
                                            &nbsp
                                            <asp:Button ID="ReturnButton" runat="server" Text="Upload File"  Width="120px" PostBackUrl="~/Login.aspx" />
                                        </td>

                                    </tr>
                                    <tr>
                                        <td colspan="2" >&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    </td>
            </tr>
        </table>
        
        </asp:Panel>
    </div>
    </form>
</body>
</html>
