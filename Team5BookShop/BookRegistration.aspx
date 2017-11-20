<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookRegistration.aspx.cs" Inherits="BookRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-12"><br /></div>
            <div class="col-md-2">
                ISBN: 
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtISBN" runat="server" Width="199px"></asp:TextBox>
            </div> 
            <div class="col-md-12"><br /></div>

            <div class="col-md-2">
                Book Category:
            </div>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlistCat" runat="server" Width="199px"></asp:DropDownList>
            </div>
            <div class="col-md-12"><br /></div>

            <div class="col-md-2">
                Book Title:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtTitle" runat="server" Width="199px"></asp:TextBox>
            </div>
            <div class="col-md-12"><br /></div>

            <div class="col-md-2">
                Author:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtAuthor" runat="server" Width="199px"></asp:TextBox>
            </div>            
            <div class="col-md-12"><br /></div>

            <div class="col-md-2">
                Book Price:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtPrice" runat="server" Width="199px"></asp:TextBox>
            </div>
            <div class="col-md-12"><br /></div>

            <div class="col-md-2">
                Book Stock:
            </div>
            <div class="col-md-10">
                <input type="number" id="bookStock" runat="server" min="0" width="199px" />
            </div>
            <div class="col-md-12"><br /></div>
        </div>
    </div>
</asp:Content>

