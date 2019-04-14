<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="ReviewPage.aspx.cs" Inherits="ReviewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style6" style="text-decoration: underline; text-align: center;">
        <strong>Review Page</strong></p>
    <p>
        <strong>
        <asp:Label ID="lblContactUsEmail" runat="server" CssClass="auto-style3" Text="Email"></asp:Label>
        </strong>&nbsp;<strong><asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style3"></asp:TextBox>
        </strong>
    </p>
    <p>
        <strong>
        <asp:Label ID="lblExp" runat="server" CssClass="auto-style3" Text="How was you experience ? "></asp:Label>
        </strong>&nbsp;<strong><asp:TextBox ID="txtExp" runat="server" CssClass="auto-style3" Height="16px" Width="917px"></asp:TextBox>
        </strong>
    </p>
    <p>
        <strong>
        <asp:Label ID="lblImproveexp" runat="server" CssClass="auto-style3" Text="How can we improve the experience ?"></asp:Label>
&nbsp;<asp:TextBox ID="txtImproveexp" runat="server" CssClass="auto-style3" Height="16px" Width="836px"></asp:TextBox>
        </strong>
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </p>
    <p>
        <strong>
        <asp:Button ID="btnEnterReview" runat="server" CssClass="auto-style3" Text="Enter Review" OnClick="btnEnterReview_Click" />
        <span class="auto-style3">&nbsp; </span>
        <asp:Button ID="btnBackToReviewPanel" runat="server" CssClass="auto-style3" Text="Back to Reviews Panel" OnClick="btnBackToReviewPanel_Click" />
        </strong>
    </p>
</asp:Content>

