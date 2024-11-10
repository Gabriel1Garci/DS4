<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio153.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 2px;
        }
    </style>
</head>
<body style="height: 100px">
    <form id="form1" runat="server">
        <p>
            Introduzca un Texto
        </p>
        <p>
            <asp:TextBox ID="txbCaja" runat="server" Width="149px"></asp:TextBox>
            <asp:Button ID="btnSaludo" runat="server" OnClick="btnSaludo_Click" Text="Enviar Saludo!" Width="181px" />
        </p>
    </form>
</body>
</html>
