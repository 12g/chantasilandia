<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMantenedorJuegos.aspx.cs" Inherits="WebApp.FormMantenedorJuegos" %>

<asp:Content ID="MantenedorHeadContent" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Mantenedor de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="MantenedorContent" ContentPlaceHolderID="ContentBody" runat="server">
    <table class="table">
        <thead>
            <tr>
                <td class="column1"><h3>Mantenedor de Juegos</h3></td>
                <td class="column2"><asp:Button ID="btnLimpiar" runat="server" Text="Limpiar Formulario" OnClick="BtnLimpiar_Click" /></td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class="column1">ID</td>
                <td class="column2"><asp:Label ID="txtID" runat="server" CssClass="input"></asp:Label></td>
            </tr>
            <tr>
                <td class="column1">Nombre</td>
                <td class="column2"><asp:TextBox ID="txtNombre" runat="server" CssClass="input"></asp:TextBox></td>
                <td class="column3"><asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" /></td>
            </tr>
            <tr>
                <td class="column1">Tipo</td>
                <td class="column2">
                    <asp:DropDownList ID="ddTipoJuego" runat="server" CssClass="dropdown" OnSelectedIndexChanged="ddTipoJuego_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Enabled="True" Selected="True" Value="">(Seleccione una opción)</asp:ListItem>
                        <asp:ListItem Value="0">Extremo</asp:ListItem>
                        <asp:ListItem Value="1">Casual</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="column1">Nivel de Riesgo</td>
                <td class="column2"><asp:DropDownList ID="ddNivelRiesgo" runat="server" CssClass="dropdown">
                        <asp:ListItem Enabled="True" Selected="True" Value="">(Seleccione una opción)</asp:ListItem>
                        <asp:ListItem Value="0">Ninguno</asp:ListItem>
                        <asp:ListItem Value="1">Moderado</asp:ListItem>
                        <asp:ListItem Value="2">Riesgoso</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="column1">Altura</td>
                <td class="column2"><asp:TextBox ID="txtAltura" runat="server" TextMode="Number" CssClass="input" /></td>
            </tr>
            <tr>
                <td class="column1">¿Requiere Supervisión?</td>
                <td class="column2"><asp:CheckBox ID="chkRequiereSupervision" runat="server" /></td>
            </tr>
            <tr>
                <td class="column1">¿Posee Cinturón?</td>
                <td class="column2"><asp:CheckBox ID="chkPoseeCinturon" runat="server" /></td>
            </tr>
            <tr>
                <td class="column1"></td>
                <td class="column2">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Enabled="false" />
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" Enabled="false" OnClick="btnBorrar_Click" />
                </td>
            </tr>
            <tr><td class="column1"><br /><br /></td></tr>
            <tr>
                <td class="column1"><asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label></td>
            </tr>
        </tbody>
    </table>
</asp:Content>
