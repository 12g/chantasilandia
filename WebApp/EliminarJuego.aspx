<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarJuego.aspx.cs" Inherits="WebApp.EliminarJuego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Eliminar juego<br />
        <br />
        Ingrese ID del juego
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarJuego.aspx">Agregar Juego</asp:HyperLink>
        <br />
    
    </div>
    </form>
</body>
</html>
