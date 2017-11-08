<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMantenedorTickets.aspx.cs" Inherits="WebApp.FormMantenedorTicket" %>

<asp:Content ID="MantenedorHeadContent" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Mantenedor de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="MantenedorContent" ContentPlaceHolderID="ContentBody" runat="server">
    <table class="table">
        <thead>
            <tr>
                <td class="column1">Mantenedor de tickets</td>
                <td class="column2"><asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" /></td>
            </tr>
            <tr>
                <td class="column1">ID</td>
                <td class="column2"><asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
                <td class="column3"><asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" /></td>
            </tr>
            <tr>
                <td class="column1">Valor</td>
                <td class="column2"><asp:TextBox ID="txtValor" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="column1"></td>
                <td class="column2">
                    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                    <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Enabled="false" />
                    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Enabled="false" />
                </td>
            </tr>
            <tr>
                <td class="column1"><asp:Label ID="lblMensaje" runat="server" Text="Mensaje"></asp:Label></td>
            </tr>
        </thead>
    </table>
</asp:Content>