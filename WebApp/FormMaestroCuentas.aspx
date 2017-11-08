<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master"  AutoEventWireup="true" CodeBehind="FormMaestroCuentas.aspx.cs" Inherits="WebApp.FormMaestroCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Maestro de Cuentas - Chantasilandia</title>
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
                    <asp:GridView ID="GdCuentas" runat="server"></asp:GridView>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
