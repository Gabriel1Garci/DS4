<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionProductos.aspx.cs" Inherits="TiendaVideoJuegosWeb.GestionProductos" Async="true" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Gestión de Productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Gestión de Productos</h2>

            <h3>Listado de Productos</h3>
            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" CssClass="table">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID Producto" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Stock" HeaderText="Stock" />
                </Columns>
                <EmptyDataTemplate>
                    <div>No hay productos disponibles.</div>
                </EmptyDataTemplate>
            </asp:GridView>

            <h3>Agregar/Editar Producto</h3>
            <label for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <label for="txtDescripcion">Descripción:</label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            <br />
            <label for="txtPrecio">Precio:</label>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <br />
            <label for="txtStock">Stock:</label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnGuardar" runat="server" Text="Guardar Producto" OnClick="BtnGuardar_Click" />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
