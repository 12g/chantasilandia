<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormMaestroJuegos.aspx.cs" Inherits="WebApp.FormListaJuegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Maestro de Juegos - Chantasilandia</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="row">
        <div class="col-xs-12 text-center">
            <asp:GridView ID="GdJuegos" runat="server" DataSourceID="JuegosChantasilandiaDB" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="2" DataKeyNames="N°" ForeColor="#333333" GridLines="None" CssClass="table" HorizontalAlign="Left" RowStyle-HorizontalAlign="Left">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="N°" HeaderText="N°" InsertVisible="False" ReadOnly="True" SortExpression="N°" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Tipo" HeaderText="Tipo" ReadOnly="True" SortExpression="Tipo" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="JuegosChantasilandiaDB" runat="server" ConnectionString="<%$ ConnectionStrings:ChantasilandiaDB %>" 
                SelectCommand="
                    SELECT 
	                    juegoID AS 'N°', 
	                    juegoNombre AS 'Nombre', 
	                    (CASE juegoTipo WHEN 0 THEN 'Extremo' WHEN 1 THEN 'Casual' ELSE '???' END) AS 'Tipo' 
                    FROM Juegos;">
            </asp:SqlDataSource>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-4 text-center">
            <asp:Button ID="BtnVer" runat="server" Text="Ver" CssClass="btn btn-primary" OnClick="BtnVer_Click" />
        </div>
        <div class="col-xs-4 text-center">
            <asp:Button ID="BtnEditar" runat="server" Text="Editar" CssClass="btn btn-warning" />
        </div>
        <div class="col-xs-4 text-center">
            <asp:Button ID="BtnBorrar" runat="server" Text="Borrar" CssClass="btn btn-danger" />
        </div>
    </div>
</asp:Content>
