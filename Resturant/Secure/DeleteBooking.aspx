<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="DeleteBooking.aspx.cs" Inherits="DeleteBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style3">
        <strong>The booking has now been deleted</strong></p>
    <p>
        <strong>
        <asp:Button ID="btnBackToBookings" runat="server" Height="43px" Text="Back to Bookings Page " Width="222px" CssClass="auto-style3" OnClick="btnBackToBookings_Click" />
        </strong>
    </p>
</asp:Content>

