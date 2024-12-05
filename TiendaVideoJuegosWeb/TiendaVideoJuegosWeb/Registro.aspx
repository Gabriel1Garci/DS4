<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TiendaVideojuegosWeb.Registro" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Registro de Usuario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registro de Usuario</h2>
            <label for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <label for="txtApellido">Apellido:</label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            <label for="txtEmail">Correo Electrónico:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <label for="txtPassword">Contraseña:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="BtnRegister" runat="server" Text="Registrar" OnClick="BtnRegister_Click" />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>