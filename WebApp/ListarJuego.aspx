<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarJuego.aspx.cs" Inherits="WebApp.ListarJuego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Listar Juegos<br />
        <br />
        Juegos Disponibles<br />
        <br />
        <asp:GridView ID="gdListar" runat="server">
            <Columns>
                <asp:BoundField ReadOnly="True" />
                <asp:BoundField ReadOnly="True" />
            </Columns>
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
