<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="central.Controls.Login" %>

<asp:Panel ID="pnlLogin" runat="server">

<div class = "TableRow">
    <div class = "TableLeft">
        Username:
    </div>
    <div class = "TableRight">
        <asp:TextBox 
            ID="txtUsername" 
            runat="server">
        </asp:TextBox>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            ControlToValidate="txtUsername" 
            ErrorMessage="RequiredFieldValidator" 
            ForeColor="Red" 
            ValidationGroup="Login">*
        </asp:RequiredFieldValidator>
    </div>
</div>

<div class = "TableRow">
    <div class = "TableLeft">
        Password:
    </div>
    <div class = "TableRight">
        <asp:TextBox 
            ID="txtPassword" 
            runat="server" 
            TextMode="Password">
        </asp:TextBox>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator2" 
            runat="server" 
            ControlToValidate="txtPassword" 
            ErrorMessage="RequiredFieldValidator" 
            ForeColor="Red" 
            ValidationGroup="Login">*
        </asp:RequiredFieldValidator>
    </div>
</div>

<div class = "TableRow">
    <div class = "TableLeft">
        &nbsp;
    </div>
    <div class = "TableRight">
        <asp:Button 
            ID="btnLogin" 
            runat="server" 
            Text="Login" 
            onclick="btnLogin_Click" 
            ValidationGroup="Login" 
         />
    </div>
</div>

<div class="TableRow">
    <asp:Label 
            ID = "lblError" 
            runat="server" 
            ForeColor="Red">
    </asp:Label>
</div>

</asp:Panel>

<asp:Panel 
    ID="pnlWelcome" runat="server">
    Welcome user!
</asp:Panel>