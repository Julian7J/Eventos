<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticaEventos.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <%-- <style>
        .oculto{display: none;}
    </style>--%>

    <asp:GridView ID="dgvDireccion" DataKeyNames="Id" OnSelectedIndexChanged="dgvDireccion_SelectedIndexChanged" CssClass="table table-dark table-bordered" runat="server">
        <Columns>
         
       <%--<asp:BoundField HeaderText="Id" DataField="Id"  HeaderStyle-CssClass="oculto"  ItemStyle-CssClass="oculto" />--%>

        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion" />

        </Columns>

    </asp:GridView>
    <a href="DireForm.aspx">Agregar</a> 
    
    <asp:Button ID="btnmodificar" OnClick="btnmodificar_Click" runat="server" Text="Modificar" />
    <asp:Button ID="btnEliminar" OnClick="btnEliminar_Click" runat="server" Text="Eliminar" />
    
</asp:Content>
