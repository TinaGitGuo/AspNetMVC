<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplicationForm.Contact" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:Button ID="Button1" runat="server" Text="Button" />
      
            
    <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
        CancelControlID="btnCancel" OkControlID="btnOkay"
        TargetControlID="Button1" PopupControlID="Panel1"
        PopupDragHandleControlID="PopupHeader" Drag="true"
        BackgroundCssClass="ModalPopupBG">
    </asp:ModalPopupExtender>

    <asp:Panel ID="Panel1" Style="display: none" runat="server">
        <div class="HellowWorldPopup">
            <div class="PopupHeader" id="PopupHeader">Header</div>
            <div class="PopupBody">
                <p>This is a simple modal dialog</p>
            </div>
            <div class="Controls">
                <input id="btnOkay" type="button" value="Done" />
                <input id="btnCancel" type="button" value="Cancel" />
            </div>
        </div>
    </asp:Panel>
              </ContentTemplate>
    </asp:UpdatePanel>
    <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server"> <ContentTemplate>

    <asp:Button ID="AddressChange" runat="server" Text="Button" />
       <asp:Panel ID="PnlAddress" runat="server"  align="center"   CssClass="modalPopup"> 
      
        <table id="address" border="0">
         
            <tr>
                <th>Region:
                </th>
                <td>
                    <asp:TextBox ID="TxtRegion" runat="server" MaxLength="30"></asp:TextBox>



                </td>
            </tr>

            <tr class="Controls">
                <td>
                    <asp:Button ID="BtnClose" runat="server" Text="Finish"
                        ValidationGroup="ADDRESS" /></td>
                <td>
                    <asp:Button ID="BtnCancel" runat="server" Text="Cancel" /></td>
            </tr>
            
        </table> </asp:Panel>

    
    <asp:ModalPopupExtender ID="ModalPopupExtenderAddress" runat="server"  BackgroundCssClass="modalBackground"   
                                         CancelControlID="BtnCancel" DropShadow="true" 
                                        OkControlID="BtnClose" OnCancelScript="CanAddress()" OnOkScript="performCheck()" PopupControlID="PnlAddress" 
                                        TargetControlID="AddressChange" ></asp:ModalPopupExtender>
        
                                                       </ContentTemplate></asp:UpdatePanel>--%>
</asp:Content>
