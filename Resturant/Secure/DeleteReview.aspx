<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="DeleteReview.aspx.cs" Inherits="DeleteReview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style3">
        <strong>The Review has now been deleted</strong></p>
    <p>
        <asp:Button ID="btnBackToReviewPage" runat="server" Height="54px" Text="Back to Review Page" Width="238px" OnClick="btnBackToReviewPage_Click" />
    </p>
</asp:Content>

