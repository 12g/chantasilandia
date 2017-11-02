<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMantenedorJuegos.aspx.cs" Inherits="WebApp.FormAgregarJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Detalles de Juegos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="row">
        <div class="col-xs-12">
            <table style="width: 100%; height: 94px;">
                <thead>
                    <tr>
                        <th>Agregar Juego</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>ID</td>
                        <td>
                            <asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkCinturon" runat="server" Text="Posee Cinturon?" /></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Nombre</td>
                        <td>
                            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkSupervision" runat="server" Text="Requiere supervision?" /></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Capacidad</td>
                        <td>
                            <asp:TextBox ID="txtCap" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Nivel de riesgo</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td>Tipo Juego</td>
                        <td>
                            <asp:DropDownList ID="ddlTipoJuego" runat="server"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td>Altura</td>
                        <td>
                            <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" Width="67px" /></td>
                        <td>
                            <asp:Button ID="btnAgregarNuevo" runat="server" OnClick="btnAgregarNuevo_Click" Text="Agregar Nuevo" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblResumen" runat="server" Text="Label"></asp:Label></td>
                        <td></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
