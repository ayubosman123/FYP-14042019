<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="DeleteContactUs.aspx.cs" Inherits="DeleteContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style3">
        <strong>The Contact Us has now been deleted</strong></p>
    <p>
        <asp:Button ID="btnBackToContactUs" runat="server" Text="Back to Contact Us Panel" OnClick="btnBackToContactUs_Click" />
    </p>
</asp:Content>

