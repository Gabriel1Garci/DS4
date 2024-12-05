<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Productos" %>

<!DOCTYPE html>
<html>
<head>
    <title>Gestión de Productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Gestión de Productos</h1>
        <label for="ddlCategorias">Categorías:</label>
        <asp:DropDownList ID="ddlCategorias" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategorias_SelectedIndexChanged">
        </asp:DropDownList>
        <br />

        <asp:Repeater ID="RepeaterProductos" runat="server">
            <ItemTemplate>
                <div>
                    <h3><%# Eval("Nombre") %></h3>
                    <p><%# Eval("Descripcion") %></p>
                    <p>Precio: <%# Eval("Precio", "{0:C}") %></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
