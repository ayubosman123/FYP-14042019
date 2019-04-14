<%@ Page Title="" Language="VB" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<asp:Login ID="Login1" runat="server" CreateUserText="Sign Up" CreateUserUrl="Register.aspx" DestinationPageUrl="Secure/DefaultBook.aspx" EnableTheming="False">
</asp:Login>
<p>
</p>
</asp:Content>

