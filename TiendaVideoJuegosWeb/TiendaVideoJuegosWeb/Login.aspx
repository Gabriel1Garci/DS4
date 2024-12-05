<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TiendaVideojuegosWeb.Login" Async="true" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Inicio de Sesión</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Inicio de Sesión</h2>
            <label for="txtEmail">Correo Electrónico:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <label for="txtPassword">Contraseña:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="BtnLogin_Click" />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <a href="Registro.aspx">¿No tienes cuenta? Regístrate aquí.</a>
        </div>
    </form>
</body>
</html>