<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Reparaciones.aspx.cs" Inherits="ExamenDeProgra.Reparaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container text-center">
        <h2>Gestión de Reparaciones</h2>

        <div>
            <h3>Agregar Reparación</h3>
            <asp:TextBox ID="txtUsuarioID" runat="server" placeholder="ID del Usuario" OnTextChanged="txtUsuarioID_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtEquipoID" runat="server" placeholder="ID del Equipo" OnTextChanged="txtEquipoID_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtFechaSolicitud" runat="server" placeholder="Fecha de Solicitud"></asp:TextBox>
            <asp:TextBox ID="txtEstado" runat="server" placeholder="Estado" OnTextChanged="txtEstado_TextChanged"></asp:TextBox>
<asp:Button ID="btnAgregarReparacion" runat="server" Text="Agregar Reparación" OnClick="btnAgregarReparacion_Click" BackColor="Green" />
        </div>

        <div>
            <h3>Listado de Reparaciones</h3>
            <asp:GridView ID="gridReparaciones" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gridReparaciones_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="ReparacionID" HeaderText="ID Reparación" />
                    <asp:BoundField DataField="UsuarioID" HeaderText="ID Usuario" />
                    <asp:BoundField DataField="EquipoID" HeaderText="ID Equipo" />
                    <asp:BoundField DataField="FechaSolicitud" HeaderText="Fecha de Solicitud" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
