<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserRegistration.aspx.cs" Inherits="UserRegisteration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:label runat="server" text="User Name: "></asp:label>
    <asp:textbox ID="txtUserName" runat="server"></asp:textbox>
    <asp:requiredfieldvalidator runat="server" errormessage="User Name cannot be empty" ControlToValidate="txtUserName">*Required</asp:requiredfieldvalidator>
    <br />
    <asp:label runat="server" text="Password: "></asp:label>
    <asp:textbox ID="txtPassword" runat="server" TextMode="Password"></asp:textbox>
    <asp:requiredfieldvalidator runat="server" errormessage="Password cannot be empty" ControlToValidate="txtPassword">*Required</asp:requiredfieldvalidator>
    <br />
    <asp:label runat="server" text="Re-enter password: "></asp:label>
    <asp:textbox ID="txtPasswordConfirmation" runat="server" TextMode="Password"></asp:textbox>
    <asp:comparevalidator runat="server" errormessage="The passwords do not match" ControlToCompare="txtPassword" ControlToValidate="txtPasswordConfirmation"></asp:comparevalidator>
    <br />
    <asp:button runat="server" text="Submit" OnClick="Unnamed7_Click" />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>

