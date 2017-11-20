<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCartPage.aspx.cs" Inherits="ShoppingCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:PlaceHolder ID="ShoppingCartph" runat="server"></asp:PlaceHolder>
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:BoundField HeaderText="Title" />
            <asp:BoundField HeaderText="Unit Price" />
            <asp:TemplateField HeaderText="Quantity"></asp:TemplateField>
            <asp:ButtonField ButtonType="Button" Text="Update" />
            <asp:BoundField HeaderText="SubTotal" />
        </Columns>
    </asp:GridView>
</asp:Content>

