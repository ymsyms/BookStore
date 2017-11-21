<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderReceipt.aspx.cs" Inherits="OrderReceipt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-12">
        <asp:Panel ID="Panel1" runat="server">
            <h3>Checkout Summary</h3>
            <asp:GridView ID="GridView1" Width="100%" runat="server" AutoGenerateColumns="False" ItemType="CartItem" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField DataField="SubTotal" HeaderText="Sub Total" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right">
                        <HeaderStyle HorizontalAlign="Right" />
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>

                </Columns>
            </asp:GridView>
            <asp:Button ID="PurchaseBtn" runat="server" Text="Purchase" />
        </asp:Panel>
    </div>
</asp:Content>

