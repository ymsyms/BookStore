<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCartPage.aspx.cs" Inherits="ShoppingCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-12">
        <asp:Panel ID="Panel1" runat="server">
            <asp:GridView ID="GridView1" Width="100%" runat="server" AutoGenerateColumns="False" ItemType="CartItem" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
                    <asp:TemplateField HeaderText="Quantity" HeaderStyle-Width="40px">
                        <HeaderStyle Width="40px" />
                        <ItemStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:TextBox ID="Quantitytb" Width="40px" Style="text-align: center" runat="server" Text='<%#:Item.Quantity%>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="SubTotal" HeaderText="Sub Total" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right">
                        <HeaderStyle HorizontalAlign="Right" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>

                    <asp:TemplateField HeaderText="Delete Item">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Delete" CommandName="DeleteCartItem" CommandArgument="<%#((GridViewRow) Container).RowIndex %>"/>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:ButtonField HeaderText="Delete Items" Text="Delete" CommandName="DeleteCartItem" ButtonType="Button" />

                </Columns>
            </asp:GridView>
        </asp:Panel>
    </div>
</asp:Content>

