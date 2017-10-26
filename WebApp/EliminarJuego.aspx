<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EliminarJuego.aspx.cs" Inherits="WebApp.EliminarJuego1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Chantasilandia - Borrar Juego</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron text-center">
        <h1>Eliminar Juego</h1>
    </div>
    <div class="row">
        <div class="col-12">
            <asp:Label runat="server">Ingrese ID del juego</asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        </div>
    </div>
    <div class="row">
        <div class="col-12">
            <asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
</asp:Content>
