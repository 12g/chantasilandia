<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebApp.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <title>Login - Chantasilandia</title>
</head>
<body class="bg-warning">
    <div class="container">
        <div class="row">
            <div class="col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3">
                <form id="FormLogin" runat="server">
                    <div class="form-group">
                        <label for="TextBoxEmail">Email</label>
                        <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TextBoxPassword">Clave</label>
                        <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="ButtonSubmit" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="OnSubmit" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
