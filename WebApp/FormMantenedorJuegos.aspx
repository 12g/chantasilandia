<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMantenedorJuegos.aspx.cs" Inherits="WebApp.FormMantenedorJuegos" %>

<asp:Content ID="MantenedorHeadContent" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Mantenedor de Juegos - Chantasilandia</title>
    
</asp:Content>
<asp:Content ID="MantenedorContent" ContentPlaceHolderID="ContentBody" runat="server">
    <table class="auto-style3">
        <thead>
            <tr>
                <td class="column1"><h3>Mantenedor de Juegos</h3></td>
                <td class="column2"><asp:Button ID="BtnLimpiar" runat="server" Text="Limpiar Formulario" OnClick="BtnLimpiar_Click" /></td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class="column1">ID</td>
                <td class="column2"><asp:Label ID="TxtID" runat="server" CssClass="input"></asp:Label></td>
            </tr>
            <tr>
                <td class="column1">Nombre</td>
                <td class="column2"><asp:TextBox ID="TxtNombre" runat="server" CssClass="input"></asp:TextBox></td>
                <td class="column3"><asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" /></td>
            </tr>
            <tr>
                <td class="column1">Tipo</td>
                <td class="column2">
                    <asp:DropDownList ID="DdTipoJuego" runat="server" CssClass="dropdown" OnSelectedIndexChanged="DdTipoJuego_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Enabled="True" Selected="True" Value="">(Seleccione una opción)</asp:ListItem>
                        <asp:ListItem Value="0">Extremo</asp:ListItem>
                        <asp:ListItem Value="1">Casual</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="column1">Nivel de Riesgo</td>
                <td class="column2"><asp:DropDownList ID="DdNivelRiesgo" runat="server" CssClass="dropdown">
                        <asp:ListItem Enabled="True" Selected="True" Value="">(Seleccione una opción)</asp:ListItem>
                        <asp:ListItem Value="0">Ninguno</asp:ListItem>
                        <asp:ListItem Value="1">Moderado</asp:ListItem>
                        <asp:ListItem Value="2">Riesgoso</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="column1">Altura</td>
                <td class="column2"><asp:TextBox ID="TxtAltura" runat="server" TextMode="Number" CssClass="input" /></td>
            </tr>
            <tr>
                <td class="column1">¿Requiere Supervisión?</td>
                <td class="column2"><asp:CheckBox ID="ChkRequiereSupervision" runat="server" /></td>
            </tr>
            <tr>
                <td class="column1">¿Posee Cinturón?</td>
                <td class="column2"><asp:CheckBox ID="ChkPoseeCinturon" runat="server" /></td>
            </tr>
            <tr>
                <td class="column1"></td>
                <td class="column2">
                    <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
                    <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" OnClick="BtnActualizar_Click" Enabled="false" />
                    <asp:Button ID="BtnBorrar" runat="server" Text="Borrar" Enabled="false" OnClick="BtnBorrar_Click" />
                </td>
            </tr>
            <tr><td class="column1"><br /><br /></td></tr>
            <tr>
                <td class="column1"><asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label></td>
            </tr>
        </tbody>
    </table>
</asp:Content>
