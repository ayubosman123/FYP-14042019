<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="DefaultCust.aspx.cs" Inherits="DefaultCust" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="font-size: x-large; text-decoration: underline">CUSTOMER&nbsp; Panel </span></strong>
</p>
    <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
    <strong>
<br />
<br />
<asp:ListBox ID="lstCust" runat="server" Height="178px" Width="843px" CssClass="auto-style3" style="font-weight: bold"></asp:ListBox>
    </strong>
<p>
    <strong>
    <asp:Button ID="btnAddCustomer" runat="server" Height="36px" Text="AddCustomer" Width="266px" OnClick="btnAddCustomer_Click" CssClass="auto-style3" style="font-weight: bold" />
    <span class="auto-style3">&nbsp;
    &nbsp;</span><asp:Button ID="btnEdit" runat="server" Height="36px" OnClick="btnEdit_Click" style="margin-top: 0px; font-weight: bold;" Text="Edit Customer" Width="224px" CssClass="auto-style3" />
    <asp:Button ID="btnDeleteCustomer" runat="server" Text="Delete Customer" OnClick="btnDeleteCustomer_Click" style="margin-left: 32px; font-weight: bold;" CssClass="auto-style3" Height="38px" Width="223px" />
    <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></strong></p>
    <p class="auto-style5" style="text-align: left">
        <strong>
    <asp:Label ID="lblError" runat="server" CssClass="auto-style5" ForeColor="Red" BorderStyle="None" Height="36px" style="font-size: large" Width="843px"></asp:Label>
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
    </strong>&nbsp;<strong><asp:Button ID="btnFilterEmail" runat="server" Text="Filter by Email" OnClick="btnFilterEmail_Click" CssClass="auto-style3" style="font-weight: bold" Width="177px" />
    <span class="auto-style3">&nbsp;&nbsp;
    </span>
    <asp:Button ID="btnDisplayAll" runat="server" Text="Display All Customers" OnClick="btnDisplayAll_Click" CssClass="auto-style3" Height="34px" style="font-weight: bold" Width="204px" />
    </strong>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

