<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_19_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1>Consumo de Web API</h1>
        <asp:Button ID="btnGetAll" runat="server" Text="Obtener Todos los Valores" OnClick="btnGetAll_Click" />
        <br /><br />
        <asp:Label ID="lblResult" runat="server" Text="" />
    </main>

</asp:Content>

