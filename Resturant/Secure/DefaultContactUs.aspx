<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="DefaultContactUs.aspx.cs" Inherits="DefaultCont" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="font-size: x-large; text-decoration: underline">Contact Us&nbsp; Panel </span></strong>
</p>
    <p>
        <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
</p>
    <strong>
<asp:ListBox ID="lstCont" runat="server" Height="178px" Width="843px" CssClass="auto-style3" style="font-weight: bold"></asp:ListBox>
    </strong>
<p>
    <strong>
    <span class="auto-style3">&nbsp;
    &nbsp;</span><asp:Button ID="btnAddCont" runat="server" CssClass="auto-style3" style="font-weight: bold" Text="Add Contact Us" OnClick="btnAddCont_Click" />
    <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEditCont" runat="server" CssClass="auto-style3" style="font-weight: bold" Text="Edit Contact Us" OnClick="btnEditCont_Click" />
    &nbsp;&nbsp;&nbsp;</span><asp:Button ID="btnDeleteCont" runat="server" CssClass="auto-style3" style="font-weight: bold; margin-left: 97px" Text="Delete Contact Us" OnClick="btnDeleteCont_Click" />
    </strong></p>
    <p class="auto-style5" style="text-align: left">
        <strong>
    <asp:Label ID="lblError" runat="server" CssClass="auto-style5" ForeColor="Red" BorderStyle="None" Height="39px" Width="850px"></asp:Label>
        <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></strong>
</p>
<p class="auto-style5" style="text-align: left">
    <strong>
    <asp:Label ID="lblFilterEmail" runat="server" Text="Please enter email" CssClass="auto-style3"></asp:Label>
&nbsp;For Filtering</strong></p>
<p class="auto-style5" style="text-align: left">
    <strong><span class="auto-style3">&nbsp;
    </span>
    <asp:TextBox ID="txtFilter" runat="server" Height="25px" Width="327px" CssClass="auto-style3" style="font-weight: bold; margin-left: 0px"></asp:TextBox>
    </strong>&nbsp;<strong><span class="auto-style3">&nbsp;&nbsp;
    </span>
    <asp:Button ID="btnFilterEmailCont" runat="server" CssClass="auto-style3" style="font-weight: bold" Text="Filter Email" OnClick="btnFilterEmailCont_Click" />
&nbsp;<asp:Button ID="btnDisplayAllCont" runat="server" CssClass="auto-style3" style="font-weight: bold; margin-left: 36px" Text="Display All Contact Us" OnClick="btnDisplayAllCont_Click" />
    </strong>
</p>
</asp:Content>

