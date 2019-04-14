<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="DefaultBook.aspx.cs" Inherits="DefaultBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;<strong><span class="auto-style3" style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Booking</span><span class="auto-style3" style="text-decoration: underline; font-size: x-large">&nbsp; Panel</span><span style="font-size: x-large; text-decoration: underline"> </span>
        </strong>
    </p>
    <strong>
    <br />
<asp:Label ID="lblUserInfo" runat="server"></asp:Label>
<br />
<br />
    <asp:ListBox ID="lstBooking" runat="server" Height="156px" Width="1447px" CssClass="auto-style3" style="font-weight: bold" ></asp:ListBox>
    </strong>
    <p>
        <strong><span class="auto-style3">&nbsp;&nbsp;</span><asp:Button ID="btnAddBooking" runat="server" Height="31px" style="margin-left: 0px; font-weight: bold;" Text="Add Booking" Width="167px" CssClass="auto-style3" OnClick="btnAddBooking_Click" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:Button ID="btnEditBooking" runat="server" Height="29px" Text="Edit Booking" Width="179px" CssClass="auto-style3" style="font-weight: bold; margin-left: 0px" OnClick="btnEditBooking_Click" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:Button ID="btnDeleteBooking" runat="server" Text="Delete Booking" Width="183px" CssClass="auto-style3" Height="29px" style="font-weight: bold" OnClick="btnDeleteBooking_Click" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></strong></p>
    <p>
    <asp:Label ID="lblError" runat="server" BorderColor="Red" BorderWidth="1px" CssClass="auto-style5" ForeColor="Red"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    </p>
    <p>
        <strong>
        <asp:Label ID="lblFilterEmail" runat="server" Text="Please enter User email for filtering" CssClass="auto-style3"></asp:Label>
        </strong>
    </p>
    <p>
        <strong><span class="auto-style3">&nbsp;
        </span>
        <asp:TextBox ID="txtFilter" runat="server" Height="27px" Width="272px" CssClass="auto-style3" style="font-weight: bold"></asp:TextBox>
        &nbsp;</strong>&nbsp;<asp:Button ID="btnUserFilter" runat="server" Height="29px" OnClick="btnUserFilter_Click" style="font-size: large" Text="Filter Using Email" Width="182px" />
        <strong><asp:Button ID="btnDisplayAllBookings" runat="server" CssClass="auto-style3" Height="32px" style="font-weight: bold; margin-left: 30px" Text="Display All Bookings" Width="186px" OnClick="btnDisplayAllBookings_Click" />
        </strong>
        </p>
    <p class="auto-style3">
        &nbsp;</p>
</asp:Content>

