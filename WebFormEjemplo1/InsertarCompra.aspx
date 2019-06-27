<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraBootstrap.Master" AutoEventWireup="true" CodeBehind="InsertarCompra.aspx.cs" Inherits="WebFormEjemplo1.InsertarCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    
    <br />
    <h1>Insertar Compra</h1>
     <br />
     <br />
    <label>Compra ID</label>
    <br />
    <asp:TextBox ID="txtCompraId" runat="server"></asp:TextBox>
     <br />
    <label>Producto</label><br />
    <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
     <br />
    <label>Cantidad</label><br />
    <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
     <br />
    <label>Precio Unitario</label><br />
    <asp:TextBox ID="txtPrecioUnitario" runat="server"></asp:TextBox>
     <br />
    <label>ID Usuario</label><br />
    <asp:TextBox ID="txtUsuarioID" runat="server"></asp:TextBox>

     <br />
    
     <br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    
</asp:Content>
