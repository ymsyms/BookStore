<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchCategoryResult.aspx.cs" Inherits="SearchCategoryResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table border="1">
                <% foreach (string key in Request.QueryString.AllKeys)
                    { %>
                <tr>
                    <td><%= key %> </td>
                    <td><%= Request.QueryString[key] %></td>
                </tr>
                <% } %>
            </table>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>

