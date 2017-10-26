<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarJuegos.aspx.cs" Inherits="WebApp.ListarJuegos1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Chantasilandia - Editar Juego</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <h3>Modificar Juego</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-4">
                Ingrese ID:
            </div>
            <div class="col-xs-8">
                <asp:TextBox ID="txtIdBsc" runat="server"></asp:TextBox>
            </div>
            <div class="col-xs-12 text-center">
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <div class="col-xs-4">
                    ID:
                </div>
                <div class="col-xs-8">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="col-xs-4">
                    Nombre:
                </div>
                <div class="col-xs-8">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="col-xs-4">
                    Tipo Juego
                </div>
                <div class="col-xs-8">
                    <asp:DropDownList ID="ddlTipoJuego" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-xs-12">
                <div class="col-xs-4">
                    Nivel de riesgo:
                </div>
                <div class="col-xs-8">
                    <asp:DropDownList ID="ddlRiesgo" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-xs-12">
                <div class="col-xs-4">
                    Capacidad:
                </div>
                <div class="col-xs-8">
                    <asp:TextBox ID="txtCapacidad" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-xs-12">
                <div class="col-xs-4">
                    Altura:
                </div>
                <div class="col-xs-8">
                    <asp:TextBox ID="txtAltura" runat="server" Style="margin-bottom: 0px"></asp:TextBox>
                </div>
            </div>
            <div class="col-xs-12">
                <div class="col-xs-4">
                    Posee cinturon?
                </div>
                <div class="col-xs-8">
                    <asp:CheckBox ID="chkPoseeCinuron" runat="server" Text="Posee Cinturon?" />
                </div>
            </div>
            <div class="col-xs-12">
                <div class="col-xs-4">
                    Requiere supervision?
                </div>
                <div class="col-xs-8">
                    <asp:CheckBox ID="chkSupervision" runat="server" Text="Requiere Supervision?" />
                </div>
            </div>
            <div class="col-xs-12">
                <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" Width="67px" />
            </div>
            <div class="col-xs-12">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
