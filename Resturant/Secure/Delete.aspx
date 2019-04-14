<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style3">
        <strong>The customer has now been deleted
    </strong>
    </p>
    <p>
        <strong>
        <asp:Button ID="btnbacktocustomerpage" runat="server" Height="45px" OnClick="btnbacktocustomerpage_Click" Text="back to customer homepage" Width="287px" CssClass="auto-style3" />
        </strong>
    </p>
</asp:Content>

