<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PersonUpdate.aspx.cs" Inherits="TurkishExporter.PersonUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="container">
            <div class="form-group mt-2">
                <asp:label id="Label1" runat="server" cssclass="control-label"  text="Sıra"></asp:label>
                <asp:textbox id="TextBox1" cssclass="form-control" ReadOnly="true" runat="server"></asp:textbox>
            </div>
            <div class="form-group">
                <asp:label id="Label2" runat="server" cssclass="control-label" text="Adı Soyadı"></asp:label>
                <asp:textbox id="TextBox2" cssclass="form-control" runat="server"></asp:textbox>
            </div>
            <asp:button id="Button1" cssclass="btn btn-primary" runat="server" OnClick="Button1_Click" text="Güncelle" />
            <asp:button id="Button2" cssclass="btn btn-primary" runat="server" OnClick="Button2_Click" text="Sil" />
        </div>
    </div>
</asp:Content>
