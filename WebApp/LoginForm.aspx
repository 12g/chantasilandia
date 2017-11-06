<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebApp.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Login - Chantasilandia</title>
</head>
<body>
    <form id="FormLogin" runat="server">
        <label for="TextBoxEmail">Email</label>
        <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
        <label for="TextBoxPassword">Clave</label>
        <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        <asp:Button ID="ButtonSubmit" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="OnSubmit" />
    </form>
</body>
</html>
