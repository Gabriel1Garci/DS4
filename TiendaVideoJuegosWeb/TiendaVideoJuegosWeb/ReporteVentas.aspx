<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteVentas.aspx.cs" Inherits="TiendaVideoJuegosWeb.ReporteVentas" Async="true" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <title>Reporte de Ventas</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Reporte de Ventas</h1>
        <asp:Repeater ID="RepeaterVentas" runat="server">
            <HeaderTemplate>
                <div style="font-weight: bold;">Ventas:</div>
            </HeaderTemplate>
            <ItemTemplate>
                <div style="margin-bottom: 15px;">
                    <p>Fecha: <%# ((dynamic)Container.DataItem).FechaCompra %></p>
                    <p>Total: <%# string.Format("{0:C}", ((dynamic)Container.DataItem).Total) %></p>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                <div style="margin-top: 10px; font-style: italic;">Fin del reporte.</div>
            </FooterTemplate>
        </asp:Repeater>
        <asp:Literal ID="LiteralMensaje" runat="server"></asp:Literal>
    </form>
</body>
</html>