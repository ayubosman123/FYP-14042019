<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="ContactUsPage.aspx.cs" Inherits="ContactUsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style6" style="text-decoration: underline">
        <strong>Contact Us Page</strong></p>
    <p>
        <strong>
        <asp:Label ID="lblContactUsEmail" runat="server" CssClass="auto-style3" Text="Email"></asp:Label>
        </strong>&nbsp;<strong><asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style3"></asp:TextBox>
        </strong>
    </p>
    <p>
        <strong>
        <asp:Label ID="lblName" runat="server" CssClass="auto-style3" Text="Name"></asp:Label>
        </strong>&nbsp;<strong><asp:TextBox ID="txtName" runat="server" CssClass="auto-style3"></asp:TextBox>
        </strong>
    </p>
    <p>
        <strong>
        <asp:Label ID="lblMessage" runat="server" CssClass="auto-style3" Text="Message"></asp:Label>
        <asp:TextBox ID="txtMessage" runat="server" CssClass="auto-style3" Height="71px" style="margin-left: 0px" Width="1029px"></asp:TextBox>
        </strong>
    </p>
    <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
    <p>
        <strong>
        <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style3" Text="Submit" style="font-weight: 700" OnClick="btnSubmit_Click" />
        &nbsp;<asp:Button ID="btnBackToContactUsPanel" runat="server" style="font-weight: 700; font-size: large; margin-left: 41px" Text="Back to Contact Us Panel" OnClick="btnBackToContactUsPanel_Click" />
        </strong>
    </p>
</asp:Content>

