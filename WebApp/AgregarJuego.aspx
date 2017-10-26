<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarJuego.aspx.cs" Inherits="WebApp.AgregarJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Chantasilandia - Agregar Juego</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <h3>Agregar Juego</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <div class="col-xs-4">ID</div>
                <div class="col-xs-8">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="col-xs-4">Nombre</div>
                <div class="col-xs-8">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <div class="col-xs-4">Capacidad</div>
                <div class="col-xs-8">
                    <asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="col-xs-4">Nivel de riesgo</div>
                <div class="col-xs-8">
                    <asp:DropDownList ID="ddlRiesgo" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <asp:CheckBox ID="chkCinturon" runat="server" Text="Posee Cinturon?" />
            </div>
            <div class="col-sm-6">
                <asp:CheckBox ID="chkSupervision" runat="server" Text="Requiere supervision?" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <div class="col-xs-4">Tipo Juego</div>
                <div class="col-xs-8">
                    <asp:DropDownList ID="ddlTipoJuego" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="col-xs-4">Altura</div>
                <div class="col-xs-8">
                    <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" Width="67px" />
            </div>
            <div class="col-sm-6">
                <asp:Button ID="btnAgregarNuevo" runat="server" OnClick="btnAgregarNuevo_Click" Text="Agregar Nuevo" />
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <asp:Label ID="lblResumen" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
