<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraBootstrap.Master" AutoEventWireup="true" CodeBehind="ListarCompras.aspx.cs" Inherits="WebFormEjemplo1.ListarCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h1>Listado de Compras</h1>
    
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped"></asp:GridView>
</asp:GridView>
</asp:Content>
