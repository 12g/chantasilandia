<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMaestroJuegos.aspx.cs" Inherits="WebApp.FormListaJuegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Maestro de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="GdJuegosCasuales" runat="server" CellPadding="4">
                </asp:GridView>
            </asp:TableCell>
            <asp:TableCell>
                <asp:GridView ID="GdJuegosExtremos" runat="server" CellPadding="4">
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Mantener" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button3" runat="server" Text="Buscar" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
