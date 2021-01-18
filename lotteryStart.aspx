<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="lotteryStart.aspx.cs" Inherits="TurkishExporter.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="containernew">
        <div class="rows">
            <asp:ListBox ID="ListBox1" Width="500" Height="400" CssClass="mybox" runat="server"></asp:ListBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick"></asp:Timer>
        <asp:ScriptManager ID="ScriptManager1"  runat="server"></asp:ScriptManager>
    </div>
</asp:Content>
