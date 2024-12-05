<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarBarco.aspx.cs" Inherits="ClubNauticoApp.RegistrarBarco" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Barco</title>
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
            <h2>Registro de Barco</h2>
            
            <asp:Label ID="lblMatricula" runat="server" Text="Número de Matrícula:"></asp:Label>&nbsp;<asp:TextBox ID="txtMatricula" runat="server" Placeholder="Número de Matrícula"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="lblNombreBarco" runat="server" Text="Nombre del Barco:"></asp:Label>
            <asp:TextBox ID="txtNombreBarco" runat="server" Placeholder="Nombre del Barco"></asp:TextBox><br />
            <br />

            <br />

            <asp:Label ID="lblNumeroAmarre" runat="server" Text="Número de Amarre:"></asp:Label>
            <asp:TextBox ID="txtNumeroAmarre" runat="server" Placeholder="Número de Amarre"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="lblCuota" runat="server" Text="Cuota:"></asp:Label>
            <asp:TextBox ID="txtCuota" runat="server" Placeholder="Cuota"></asp:TextBox><br />
            <br />

            <asp:Label ID="lblSocios" runat="server" Text="Propietario (Socio):"></asp:Label><br />
            <asp:DropDownList ID="ddlSocios" runat="server"></asp:DropDownList>
            <br />
            <br />

            <asp:Button ID="btnRegistrarBarco" runat="server" Text="Registrar Barco" OnClick="btnRegistrarBarco_Click" />
        </div>
    </form>
</body>
</html>
