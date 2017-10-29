<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarJuego.aspx.cs" Inherits="WebApp.ModificarJuego" %>

<!DOCTYPE html>

 <head>
     <style type="text/css">
         .auto-style1 {
             height: 26px;
         }
     </style>
</head>
<form id="form1" runat="server">

 <table class="auto-style2">
        <tr>
            <td class="auto-style1">MODIFICAR JUEGO</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Ingrese ID:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtIdBsc" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">ID:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Nombre:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Tipo Juego:</td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddlTipoJuego" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Nivel de riesgo:</td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddlRiesgo" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Capacidad:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCapacidad" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Altura:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtAltura" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style1">Posee cinturon?</td>
            <td class="auto-style1">
                <asp:CheckBox ID="chkPoseeCinuron" runat="server" Text="Posee Cinturon?" />
            </td>
            <td class="auto-style1">
                </td>
        </tr>
        <tr>
            <td class="auto-style1">Requiere supervision?</td>
            <td class="auto-style3">
                <asp:CheckBox ID="chkSupervision" runat="server" Text="Requiere Supervision?" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" Width="67px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
</form>
