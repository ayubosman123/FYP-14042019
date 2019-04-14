<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>
    <asp:Label ID="lblfirstname" runat="server" Text="First Name" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtfirstname" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lbllastname" runat="server" Text="Last Name" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtsurname" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblemail" runat="server" Text="Email " CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txteMail" runat="server" CssClass="auto-style3" Width="267px"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lbltitle" runat="server" Text="Title " CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txttitle" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblgender" runat="server" Text="Gender" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtgender" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lbldob" runat="server" Text="Date of Birth" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtdateOfBirth" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblcontactno" runat="server" Text="Contact No" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtContactNumber" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblhouseno" runat="server" Text="House No " CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtHouseno" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblpostcode" runat="server" Text="Post Code" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtpostCode" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Button ID="btnEnter" runat="server" Height="41px" Text="Enter " Width="231px" OnClick="btnEnter_Click" CssClass="auto-style3" />
    <span class="auto-style3">&nbsp;
    </span>
    <asp:Button ID="btn" runat="server" Height="38px" OnClick="btn_Click" Text="Back to Customer Panel" Width="372px" CssClass="auto-style3" />
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblError" runat="server" CssClass="auto-style3" BorderColor="Red" BorderWidth="1px" ForeColor="Red"></asp:Label>
    </strong>
    <br />
</asp:Content>

