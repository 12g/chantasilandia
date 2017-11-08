<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMaestroJuegos.aspx.cs" Inherits="WebApp.FormMaestroJuegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Maestro de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="MaestroContent" ContentPlaceHolderID="ContentBody" runat="server">
    <table id="MaestroContentTable" class="table">
        <tbody>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Font-Size="Large">Juegos Casuales</asp:Label>
                    <asp:GridView ID="GdJuegosCasuales" runat="server" CellPadding="2" />
                </td>
                <td>
                    <asp:Label runat="server" Font-Size="Large">Juegos Extremos</asp:Label>
                    <asp:GridView ID="GdJuegosExtremos" runat="server" CellPadding="2" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnEditar" runat="server" Text="Ver Detalles" OnClick="BtnEditar_Click" />
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
