<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="ExamenDeProgra.Detalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container text-center">
        <h2>Detalles de Reparación</h2>

     

         <asp:TextBox ID="txtReparacionID" runat="server" placeholder="ID de Reparación" OnTextChanged="txtReparacionID_TextChanged"></asp:TextBox>
         <asp:TextBox ID="txtDescripcion" runat="server" placeholder="Descripción" OnTextChanged="txtDescripcion_TextChanged"></asp:TextBox>
         <asp:TextBox ID="txtFechaInicio" runat="server" placeholder="Fecha de Inicio" OnTextChanged="txtFechaInicio_TextChanged"></asp:TextBox>
         <asp:TextBox ID="txtFechaFin" runat="server" placeholder="Fecha de Fin" OnTextChanged="txtFechaFin_TextChanged"></asp:TextBox>

       <asp:Button ID="btnAgregarDetalle" runat="server" Text="Agregar Detalle" OnClick="btnAgregarDetalle_Click" BackColor="Red" />

      

        <hr />

        <h3>Listado de Detalles de Reparación</h3>
         <asp:GridView ID="gridDetallesReparacion" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gridDetallesReparacion_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="DetalleID" HeaderText="ID Detalle" />
                <asp:BoundField DataField="ReparacionID" HeaderText="ID Reparación" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="FechaInicio" HeaderText="Fecha de Inicio" />
                <asp:BoundField DataField="FechaFin" HeaderText="Fecha de Fin" />
               
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
