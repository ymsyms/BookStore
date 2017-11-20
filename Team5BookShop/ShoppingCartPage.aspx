<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCartPage.aspx.cs" Inherits="ShoppingCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:PlaceHolder ID="ShoppingCartph" runat="server"></asp:PlaceHolder>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ItemType="CartItem">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="Quantitytb" Width="40px" runat="server" Text='<%#:Item.Quantity%>' ></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="SubTotal" HeaderText="Sub Total" />

        </Columns>
    </asp:GridView>
</asp:Content>

