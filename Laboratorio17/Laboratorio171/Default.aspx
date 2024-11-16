<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio171._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="row">
            <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1" 
                AllowSorting="true" AllowPaging="true"
                DataKeyNames="ProductId" AutoGenerateEditButton="false" Runat="server"/>
            <asp:SqlDataSource ID="MyDataSource1" runat="server"
                ConnectionString="Data Source=localhost; Initial Catalog=Northwind; Integrated Security=SSPI;"
                ProviderName="System.Data.SqlClient"
                SelectCommand="SELECT ProductId, ProductName,UnitPrice from Products"
                UpdateCommand="UPDATE Products SET ProductName=@ProductName, UnitPrice=@UnitePrice WHERE ProductId=@ProductId">
                </asp:SqlDataSource>
        </div>

</asp:Content>
