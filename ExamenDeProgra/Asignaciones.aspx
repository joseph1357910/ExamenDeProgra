<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Asignaciones.aspx.cs" Inherits="ExamenDeProgra.Asignaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container text-center">
        <h3>Agregar Asignación</h3>
          <asp:TextBox ID="txtEquipoID" runat="server" placeholder="ID del Equipo" OnTextChanged="txtEquipoID_TextChanged"></asp:TextBox>
          <asp:TextBox ID="txtTecnicoID" runat="server" placeholder="ID del Técnico" OnTextChanged="txtTecnicoID_TextChanged"></asp:TextBox>
          <asp:TextBox ID="txtFechaAsignacion" runat="server" placeholder="Fecha de Asignación (yyyy-mm-dd)" OnTextChanged="txtFechaAsignacion_TextChanged"></asp:TextBox>
       <asp:Button ID="btnAgregarAsignacion" runat="server" Text="Agregar Asignación" OnClick="btnAgregarAsignacion_Click" BackColor="Yellow" />

    </div>

    <div>
        <h3>Listado de Asignaciones</h3>
        <asp:GridView ID="gridAsignaciones" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gridAsignaciones_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="AsignacionID" HeaderText="ID Asignación" />
                <asp:BoundField DataField="EquipoID" HeaderText="ID Equipo" />
                <asp:BoundField DataField="TecnicoID" HeaderText="ID Técnico" />
                <asp:BoundField DataField="FechaAsignacion" HeaderText="Fecha de Asignación" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
