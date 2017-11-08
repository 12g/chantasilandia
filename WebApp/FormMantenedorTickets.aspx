<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormMantenedorTickets.aspx.cs" Inherits="WebApp.FormMantenedorTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:Menu>
        <br />
        Mantenedor de tickets<br />
        <br />
        Id :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
        <br />
        <br />
        Valor :&nbsp;
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
        <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblMensaje" runat="server" Text="Mensaje"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
