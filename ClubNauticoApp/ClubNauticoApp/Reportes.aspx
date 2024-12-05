<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="ClubNauticoApp.Reportes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reportes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Menu ID="Menu1" runat="server" CssClass="menu" Orientation="Horizontal">
    <Items>
        <asp:MenuItem Text="Registrar Socio" NavigateUrl="~/RegistrarSocio.aspx" />
        <asp:MenuItem Text="Registrar Barco" NavigateUrl="~/RegistrarBarco.aspx" />
        <asp:MenuItem Text="Reportes" NavigateUrl="~/Reportes.aspx" />
        <asp:MenuItem Text="Salidas" NavigateUrl="~/RegistrarSalida.aspx" />
    </Items>
</asp:Menu>
            <h2>Generar Reportes de Salidas</h2>

            <label for="txtFechaInicio">Fecha Inicio:</label><br />
            <asp:TextBox ID="txtFechaInicio" runat="server" Placeholder="YYYY-MM-DD"></asp:TextBox><br /><br />

            <label for="txtFechaFin">Fecha Fin:</label><br />
            <asp:TextBox ID="txtFechaFin" runat="server" Placeholder="YYYY-MM-DD"></asp:TextBox><br /><br />

            <label for="txtDestino">Destino:</label><br />
            <asp:TextBox ID="txtDestino" runat="server" Placeholder="Destino"></asp:TextBox><br /><br />

            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" /><br /><br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True"></asp:GridView>
        </div>
    </form>
</body>
</html>
