<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarSalida.aspx.cs" Inherits="ClubNauticoApp.RegistrarSalida" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Salida</title>
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
            <h2>Registro de Salida</h2>
            
            <label for="ddlBarcos">Seleccionar Barco:</label><br />
            <asp:DropDownList ID="ddlBarcos" runat="server"></asp:DropDownList><br /><br />

            <label for="ddlSocio"> Seleccionar Patrón:</label><br />
            <asp:DropDownlist ID="ddlSocios" runat="server"></asp:DropDownlist><br /><br />

            <label for="txtFechaSalida">Fecha de Salida (YYYY-MM-DD):</label><br />
            <asp:TextBox ID="txtFechaSalida" runat="server"></asp:TextBox><br /><br />

            <label for="txtHoraSalida">Hora de Salida (HH:MM):</label><br />
            <asp:TextBox ID="txtHoraSalida" runat="server"></asp:TextBox><br /><br />

            <label for="txtDestino">Destino:</label><br />
            <asp:TextBox ID="txtDestino" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="btnRegistrarSalida" runat="server" Text="Registrar Salida" OnClick="btnRegistrarSalida_Click" />
        </div>
    </form>
</body>
</html>
