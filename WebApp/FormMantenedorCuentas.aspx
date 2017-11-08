<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="FormMantenedorCuentas.aspx.cs" Inherits="WebApp.FormMantenedorCuenta" %>

<asp:Content ID="MantenedorHeadContent" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Mantenedor de Cuentas - Chantasilandia</title>
</asp:Content>
<asp:Content ID="MantenedorContent" ContentPlaceHolderID="ContentBody" runat="server">
    <table class="table">
        <thead>
            <tr>
                <td class="column1"><h3>Mantenedor de Cuentas</h3></td>
                <td class="column2"><asp:Button ID="BtnLimpiar" runat="server" OnClick="BtnLimpiar_Click" Text="Limpiar" /></td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class="column1">Id</td>
                <td class="column2"><asp:Label ID="txtId" runat="server" CssClass="input"></asp:Label></td>
            </tr>
            <tr>
                <td class="column1">Usuario</td>
                <td class="column2"><asp:TextBox ID="txtUser" runat="server"></asp:TextBox></td>
                <td class="column3"><asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" /></td>
            </tr>
            <tr>
                <td class="column1">Contraseña</td>
                <td class="column2"><asp:TextBox ID="txtPass" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="column1"></td>
                <td class="column2">
                    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Enabled="false" />
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" Enabled="false" />
                </td>
            </tr>
            <tr><td class="column1"><br /><br /></td></tr>
            <tr>
                <td class="column1"><asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </tbody>
    </table>
</asp:Content>
        