<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarJuegos.aspx.cs" Inherits="WebApp.ListarJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Chantasilandia - Juegos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <h3>Listar Juegos</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                Juegos Disponibles<br />
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <asp:GridView ID="gdListar" runat="server">
                    <Columns>
                        <asp:BoundField ReadOnly="True" />
                        <asp:BoundField ReadOnly="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
