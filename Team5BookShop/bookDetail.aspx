<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookDetail.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <asp:Image ID="Image2" runat="server" ImageUrl="images/9780060555665.jpg" />
            </div>
            <div class="col-md-8"><br /></div>
                    <div class="col-md-3">Title:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblTitle" runat="server" Text="label"></asp:Label>
                    </div>
                <div class="col-md-8"><br /></div>
                    <div class="col-md-3">Category:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblCat" runat="server" Text="Label"></asp:Label>
                    </div>
                <div class="col-md-8"><br /></div>
                    <div class="col-md-3">ISBN:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblISBN" runat="server" Text="Label"></asp:Label>
                    </div>
                <div class="col-md-8"><br /></div>
                    <div class="col-md-3">Author:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblAuthor" runat="server" Text="Label"></asp:Label>
                    </div>
                <div class="col-md-8"><br /></div>
                    <div class="col-md-3">Price:</div>
                    <div class="col-md-5">
                        <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
                    </div>
                <div class="col-md-8"><br /></div>
            <div class="col-md-3">
                <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            </div>
            <div class="col-md-5">
                <input type="number" id="qty" runat="server" min="0" />
            </div>
            <div class="col-md-8"><br /></div>
            <div class="col-md-3">
                <asp:Label ID="lblDiscCode" runat="server" Text="Discount Code"></asp:Label>
            </div>
            <div class="col-md-5">
                <asp:DropDownList ID="DdlDiscCode" runat="server">
                </asp:DropDownList>
            </div>
        <div class="col-md-8"><br /></div>
            <div class="span12 pagination-centered">
                <asp:Button ID="BtnAddToCart" runat="server" Text="Add To Cart" />
            </div>
        </div>
    </div>
</asp:Content>

