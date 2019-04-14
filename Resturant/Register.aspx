<%@ Page Title="" Language="VB" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="false" CodeFile="Register.aspx.vb" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<p>
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" ContinueDestinationPageUrl="Login.aspx">
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server" />
            <asp:CompleteWizardStep runat="server" />
        </WizardSteps>
    </asp:CreateUserWizard>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
</p>
</asp:Content>

