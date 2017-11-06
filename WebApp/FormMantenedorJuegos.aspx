<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMantenedorJuegos.aspx.cs" Inherits="WebApp.FormAgregarJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Mantenedor de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow runat="server">
            <asp:TableHeaderCell>Mantenedor de Juegos</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>Nombre</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Tipo</asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlTipoJuego" runat="server" OnSelectedIndexChanged="OnSelectTipoJuego">
                    <asp:ListItem Enabled="False" Selected="True" Value="-1">(Seleccione una opción)</asp:ListItem>
                    <asp:ListItem Value="0">Extremo</asp:ListItem>
                    <asp:ListItem Value="1">Casual</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Nivel de Riesgo</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TxtRiesgo" runat="server" TextMode="Number" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Altura</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtAltura" runat="server" TextMode="Number" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Req. Supervision</asp:TableCell>
            <asp:TableCell>
                <asp:CheckBox ID="ChkRequiereSupervision" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Posee Cinturon</asp:TableCell>
            <asp:TableCell>
                <asp:CheckBox ID="ChkPoseeCinturon" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="OnClean" />
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="OnSubmitNew" />
    <asp:Label ID="lblResumen" runat="server" Text="Label"></asp:Label>
</asp:Content>
