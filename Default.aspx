<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TurkishExporter.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table class="table table-bordered mt-3">
            <tr>
                <th>Sıra</th>
                <th>Adı Soyadı</th>
                <th>Düzenle</th>
            </tr>
            <asp:Repeater ID="listele" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("NAMESURNAME") %></td>
                        <td><a class="btn btn-danger" href="PersonUpdate.aspx?ID=<%# Eval("ID") %>&islem">Düzenle</a>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>
