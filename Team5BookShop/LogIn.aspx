<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 468px;
            margin-top: 134px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contentMenu">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Main.aspx">Home</asp:HyperLink> 
        <span>>Login</span>
    </div>
    <asp:Label ID="Label1" runat="server" Text="Enter User ID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Enter Password"></asp:Label>
    <input id="Password1" type="password" runat="server"/>
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button1_Click" />
</asp:Content>

