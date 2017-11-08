<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormMaestroticket.aspx.cs" Inherits="WebApp.FormMaestroticket" %>

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
        Tickets<asp:GridView ID="GwTicket" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
        </asp:GridView>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
