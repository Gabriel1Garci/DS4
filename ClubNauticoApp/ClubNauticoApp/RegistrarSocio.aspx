<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarSocio.aspx.cs" Inherits="ClubNauticoApp.RegistrarSocio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Socio</title>
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
            <h2>Registro de Socio</h2>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label><br />
            <asp:TextBox ID="txtNombre" runat="server" Placeholder="Nombre"></asp:TextBox><br />

            <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label><br />
            <asp:TextBox ID="txtApellido" runat="server" Placeholder="Apellido"></asp:TextBox><br />

            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label><br />
            <asp:TextBox ID="txtTelefono" runat="server" Placeholder="Teléfono"></asp:TextBox><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label><br />
            <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email"></asp:TextBox><br />

            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </div>
    </form>
</body>
</html>