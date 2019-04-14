<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="DefaultReview.aspx.cs" Inherits="DefaultReview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <strong><span class="auto-style3" style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reviews</span><span class="auto-style3" style="text-decoration: underline; font-size: x-large">&nbsp; Panel</span><span style="font-size: x-large; text-decoration: underline"> </span></strong>
    </p>
    <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
    <strong>
    <br />
    <br />
    <asp:ListBox ID="lstReviews" runat="server" Height="156px" Width="1447px" CssClass="auto-style3" style="font-weight: bold" ></asp:ListBox>
    </strong>
    <p>
        <strong><span class="auto-style3">&nbsp;&nbsp;</span><span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:Button ID="btnAddReview" runat="server" OnClick="btnAddReview_Click" Text="Add Review" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:Button ID="btnEditReview" runat="server" OnClick="btnEditReview_Click" Text="Edit Review" />
&nbsp;</strong><asp:Button ID="btnDeleteReview" runat="server" OnClick="btnDeleteReview_Click" style="margin-left: 45px" Text="Delete Review" />
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    </p>
    <p>
        <strong>
        <asp:Label ID="lblFilterEmail" runat="server" Text="Please enter Email for filtering" CssClass="auto-style3"></asp:Label>
        </strong>
    </p>
    <p>
        <strong><span class="auto-style3">&nbsp;
        </span>
        <asp:TextBox ID="txtFilter" runat="server" Height="27px" Width="272px" CssClass="auto-style3" style="font-weight: bold"></asp:TextBox>
        &nbsp;</strong>&nbsp;<asp:Button ID="btnFilterViaEmail" runat="server" OnClick="btnFilterViaEmail_Click" Text="Filter via Email" />
&nbsp;<asp:Button ID="btnDisplayAllReviews" runat="server" Height="29px" OnClick="btnDisplayAllReviews_Click" Text="Display All Reviews" Width="212px" />
    </p>
    <p class="auto-style3">
        &nbsp;</p>
</asp:Content>

