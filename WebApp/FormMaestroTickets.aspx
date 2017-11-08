<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="FormMaestroTickets.aspx.cs" Inherits="WebApp.FormMaestroticket" %>

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
                    <asp:Label runat="server" Font-Size="Large">Tickets</asp:Label>
                    <asp:GridView ID="GdTickets" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2"></asp:GridView>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
