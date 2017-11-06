<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMantenedorJuegos.aspx.cs" Inherits="WebApp.FormAgregarJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Mantenedor de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="row">
        <div class="col-xs-12">
            <h2>Mantenedor de Juegos</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-8 col-sm-offset-2">
            <div class="col-xs-6 col-sm-4">
                <label>Nombre</label>
            </div>
            <div class="col-xs-6 col-sm-8">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="col-sm-8 col-sm-offset-2">
            <div class="col-xs-6 col-sm-4">
                <label>Tipo</label>
            </div>
            <div class="col-xs-6 col-sm-8">
                <asp:DropDownList ID="ddlTipoJuego" runat="server" OnSelectedIndexChanged="OnSelectTipoJuego">
                    <asp:ListItem Enabled="False" Selected="True" Value="-1">(Seleccione una opción)</asp:ListItem>
                    <asp:ListItem Value="0">Extremo</asp:ListItem>
                    <asp:ListItem Value="1">Casual</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="row" id="divJuegoExtremo" runat="server" hidden="hidden">
        <div class="col-sm-8 col-sm-offset-2">
            <div class="checkbox">
                <label>Nivel de Riesgo</label>
            </div>
            <div class="col-xs-6 col-sm-8">
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" />
            </div>
        </div>
        <div class="col-sm-8 col-sm-offset-2">
            <div class="col-xs-6 col-sm-4">
                <label>Altura</label>
            </div>
            <div class="col-xs-6 col-sm-8">
                <asp:TextBox ID="txtAltura" runat="server" TextMode="Number" />
            </div>
        </div>
    </div>
    <div class="row" id="divJuegoCasual" runat="server" hidden="hidden">
        <div class="col-sm-8 col-sm-offset-2">
            <div class="checkbox">
                <label>
                    Requiere supervisión
                    <asp:CheckBox ID="chkRequiereSupervision" runat="server" />
                </label>
            </div>
        </div>
        <div class="col-sm-8 col-sm-offset-2">
            <div class="checkbox">
                <label>
                    Posee Cinturón
                    <asp:CheckBox ID="chkPoseeCinturon" runat="server" />
                </label>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-8 col-sm-offset-2">
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-primary" OnClick="OnClean" />
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="OnSubmitNew" />
        </div>
        <asp:Label ID="lblResumen" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
