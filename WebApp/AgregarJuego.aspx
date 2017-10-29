<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="AgregarJuego.aspx.cs" Inherits="WebApp.AgregarJuego" %>
      
<!DOCTYPE html>
<html>
<form id="form1" runat="server">
    <table style="width: 100%; height: 94px;">
        <tr>
            <td>Agregar Juego</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>ID&nbsp;
                &nbsp;<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkCinturon" runat="server" Text="Posee Cinturon?" />
                <br />
                <br />
                Nombre &nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkSupervision" runat="server" Text="Requiere supervision?" />
                <br />
                <br />
                Capacidad
                &nbsp;<asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nivel de riesgo&nbsp;
                <asp:DropDownList ID="ddlRiesgo" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                Tipo Juego
                <asp:DropDownList ID="ddlTipoJuego" runat="server">
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Altura
                <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" Width="67px" />
                <asp:Button ID="btnAgregarNuevo" runat="server" OnClick="btnAgregarNuevo_Click" Text="Agregar Nuevo" />
                <br />
                <br />
                <br />
                <asp:Label ID="lblResumen" runat="server" Text="Label"></asp:Label>
                <br />
&nbsp;
                <br />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListarJuego.aspx">Listar Juegos</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/EliminarJuego.aspx">Eliminar Juego</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ModificarJuego.aspx">Modificar juegos</asp:HyperLink>
                <br />
                <br />
                <br />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</form>
</html>
