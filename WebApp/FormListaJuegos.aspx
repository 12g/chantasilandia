<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormListaJuegos.aspx.cs" Inherits="WebApp.FormListaJuegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Lista de Juegos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="row">
        <div class="col-xs-12">
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" DataSourceID="ChantasilandiaDB" DataTextField="cuentaUsuario" DataValueField="cuentaUsuario">
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
            <asp:SqlDataSource ID="ChantasilandiaDB" runat="server" ConnectionString="<%$ ConnectionStrings:p_diversionesConnectionString %>" SelectCommand="SELECT [cuentaUsuario] FROM [Cuentas]"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
