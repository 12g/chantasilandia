<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMaestroJuegos.aspx.cs" Inherits="WebApp.FormListaJuegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Maestro de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="row">
        <div class="col-xs-12">
            
            <asp:ListBox ID="ListBox1" runat="server" DataSourceID="JuegosChantasilandiaDB" DataTextField="juegoNombre" DataValueField="juegoID"></asp:ListBox>
            <br />
            <asp:SqlDataSource ID="JuegosChantasilandiaDB" runat="server" ConnectionString="<%$ ConnectionStrings:ChantasilandiaDB %>" SelectCommand="SELECT 
	juegoID,
	juegoNombre, 
	(CASE juegoTipo WHEN 0 THEN 'Extremo' WHEN 1 THEN 'Casual' ELSE '???' END) AS juegoTipo
FROM Juegos;
"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
