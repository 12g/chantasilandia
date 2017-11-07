<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMaestroJuegos.aspx.cs" Inherits="WebApp.FormMaestroJuegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Maestro de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="MaestroContent" ContentPlaceHolderID="ContentBody" runat="server">
    <asp:Table ID="MaestroContentTable" runat="server" Width="800px">
        <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
        <asp:TableRow>
            <asp:TableCell VerticalAlign="Bottom">
                <asp:Label runat="server" Font-Size="Medium">Filtrar por Nombre</asp:Label>
                <asp:TextBox ID="TxtFiltro" runat="server" Width="99%"  />
            </asp:TableCell><asp:TableCell VerticalAlign="Bottom">
                <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" OnClick="BtnFiltrar_OnClick" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
        <asp:TableRow>
            <asp:TableCell VerticalAlign="Top">
                <asp:Label runat="server" Font-Size="Large">Juegos Casuales</asp:Label>
                <asp:GridView ID="GdJuegosCasuales" runat="server" CellPadding="2" />
            </asp:TableCell><asp:TableCell VerticalAlign="Top">
                <asp:Label runat="server" Font-Size="Large">Juegos Extremos</asp:Label>
                <asp:GridView ID="GdJuegosExtremos" runat="server" CellPadding="2" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell VerticalAlign="Top">
                <asp:Button ID="BtnEditar" runat="server" Text="Ver Detalles" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
