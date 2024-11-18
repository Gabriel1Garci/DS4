<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_19_3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h1>Consumo de Web API - Obtener Valor por ID</h1>
        <asp:Button ID="btnGetById" runat="server" Text="Obtener Valor con ID 2" OnClick="btnGetById_Click" />
        <br /><br />
        <asp:Label ID="lblResult" runat="server" Text="" />
    </main>
</asp:Content>


