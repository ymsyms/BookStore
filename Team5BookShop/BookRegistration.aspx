<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookRegistration.aspx.cs" Inherits="BookRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server" >
    <style>
        .errorAlert {
            font: bold;
            color: red;
        }
        .auto-style1 {
            width: 201px;
        }
    </style>
    <div class="container bookRegister">
        <div class="row">
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-2">
                ISBN: 
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtISBN" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtISBN" ErrorMessage="Value cannot be empty" CssClass="errorAlert"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Book Category:
            </div>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlistCat" runat="server" Width="199px"></asp:DropDownList>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Book Title:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtTitle" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Author:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtAuthor" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtAuthor"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Book Price:
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtPrice" runat="server" Width="199px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Value cannot be empty" CssClass="errorAlert" ControlToValidate="txtPrice"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-12">
                <br />
            </div>

            <div class="col-md-2">
                Book Stock:
            </div>
            <div class="col-md-10">
                <input type="number" id="bookStock" runat="server" min="0" class="auto-style1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-2">
                Discount Code:
            </div>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlDiscount" runat="server" Width="199px"></asp:DropDownList>
            </div>
            <div class="col-md-12">
                <br />
            </div>
            <div class="col-md-12 bookRegister">
                <asp:Button ID="btnAdd" runat="server" Text="Submit" OnClick="btnAdd_Click" />
            </div>  
            <div class="col-md-12"          >
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>

