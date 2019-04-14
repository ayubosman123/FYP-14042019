<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="BookingPage.aspx.cs" Inherits="BookingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>    <asp:Label ID="lblUserEmail" runat="server" Text="What is your Email ?" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtuseremail" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblDateBooked" runat="server" Text="What Date do you want the booking ?" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtDateBooked" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblTimeBooked" runat="server" Text="What Time do you want the booking ?" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtTimeBooked" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblGuestsBooked" runat="server" Text="How many guests do you want ?" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtGuestsBooked" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Label ID="lblDiningBooked" runat="server" Text="What Type of Dining. ?" CssClass="auto-style3"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="txtDiningBooked" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblError" runat="server"></asp:Label>
    <br class="auto-style3" />
    <br class="auto-style3" />
    <asp:Button ID="btnSubmitBooking" runat="server" CssClass="auto-style3" Height="39px" style="font-weight: 700" Text="Submit Booking" Width="354px" OnClick="btnSubmitBooking_Click" />
    &nbsp;&nbsp;
    </strong>
    <asp:Button ID="btnBacktoBookingPanel" runat="server" Height="37px" OnClick="btnBacktoBookingPanel_Click" style="font-weight: 700; font-size: large; margin-top: 0px" Text="Back to Booking Panel" Width="233px" />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

