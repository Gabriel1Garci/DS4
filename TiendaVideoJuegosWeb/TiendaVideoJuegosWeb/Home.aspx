<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="TiendaVideoJuegosWeb.Home" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <title>Tienda de Videojuegos</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Bienvenido a la Tienda de Videojuegos</h1>
        <ul>
            <li><a href="Productos.aspx?categoria=Consolas">Consolas</a></li>
            <li><a href="Productos.aspx?categoria=Juegos">Juegos</a></li>
            <li><a href="Productos.aspx?categoria=Accesorios">Accesorios</a></li>
            <li><a href="ReporteVentas.aspx">Reporte de Ventas</a></li>
            <li><a href="Login.aspx">Iniciar Sesión / Crear Cuenta</a></li>
            <li><a href="GestionProductos.aspx">Agregar Productos al Inventario</a></li>
        </ul>
    </form>
</body>
</html>