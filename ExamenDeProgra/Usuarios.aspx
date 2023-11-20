<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ExamenDeProgra.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container text-center">
    <h2>Mantenimiento de Usuarios</h2>

    <div>
        <h3>Agregar Usuario</h3>
        <asp:TextBox ID="txtNombreUsuario" runat="server" placeholder="Nombre de Usuario" OnTextChanged="txtNombreUsuario_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtCorreoUsuario" runat="server" placeholder="Correo Electrónico" OnTextChanged="txtCorreoUsuario_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtTelefonoUsuario" runat="server" placeholder="Teléfono" OnTextChanged="txtTelefonoUsuario_TextChanged"></asp:TextBox>
        <asp:Button ID="btnGuardarUsuario" runat="server" Text="Guardar Usuario" OnClick="btnGuardarUsuario_Click" />
    </div>

    <hr />

    <div>
        <h3>Listado de Usuarios</h3>
        <asp:GridView ID="gridUsuarios" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gridUsuarios_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="UsuarioID" HeaderText="ID Usuario" ReadOnly="True" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="CorreoElectronico" HeaderText="Correo Electrónico" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</div>
</asp:Content>
