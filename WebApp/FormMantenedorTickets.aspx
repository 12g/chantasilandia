<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMantenedorTickets.aspx.cs" Inherits="WebApp.FormMantenedorTicket" %>

<asp:Content ID="MantenedorHeadContent" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Mantenedor de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="MantenedorContent" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="row">
        <div class="col-xs-12">
            <td class="column1">Mantenedor de tickets</td>
            <td class="column2"><asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" /></td>
        </div>
        <div class="col-xs-12">
            <div class="form-group">
                <label for="txtId">ID</label>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </div>
        </div>
        <div class="col-xs-12">
            <label for="txtValor">Valor</label>
            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        </div>
        <div class="col-xs-12">
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
            <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Enabled="false" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Enabled="false" />
        </div>
        <div class="col-xs-12">
            <asp:Label ID="lblMensaje" runat="server" Text="Mensaje"></asp:Label>
        </div>
    </div>
</asp:Content>