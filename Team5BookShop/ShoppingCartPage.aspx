<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCartPage.aspx.cs" Inherits="ShoppingCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-12">
        <asp:Panel ID="Panel1" runat="server">
            <asp:GridView ID="GridView1" Width="100%" runat="server" AutoGenerateColumns="False" ItemType="CartItem">
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
                    <asp:BoundField DataField="SubTotal" HeaderText="Sub Total" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right"></asp:BoundField>
                    <asp:TemplateField HeaderText="Remove Item?" HeaderStyle-Width="70px">
                        <ItemTemplate>
                            <div style="text-align: center">
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
        </asp:Panel>
    </div>
</asp:Content>

