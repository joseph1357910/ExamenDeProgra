<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Tecnicos.aspx.cs" Inherits="ExamenDeProgra.Tecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
       <h2>Mantenimiento de Técnicos</h2>

       <div>
           <h3>Agregar Técnico</h3>
           <asp:TextBox ID="txtNombreTecnico" runat="server" placeholder="Nombre del Técnico" OnTextChanged="txtNombreTecnico_TextChanged"></asp:TextBox>
           <asp:TextBox ID="txtEspecialidadTecnico" runat="server" placeholder="Especialidad" OnTextChanged="txtEspecialidadTecnico_TextChanged"></asp:TextBox>
<asp:Button ID="btnGuardarTecnico" runat="server" Text="Guardar Técnico" OnClick="btnGuardarTecnico_Click" BackColor="Orange" />
       </div>

       <hr />

       <div>
           <h3>Listado de Técnicos</h3>
           <asp:GridView ID="gridTecnicos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gridTecnicos_SelectedIndexChanged">
               <Columns>
                   <asp:BoundField DataField="TecnicoID" HeaderText="ID Técnico" />
                   <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                   <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" />
                   <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
               </Columns>
           </asp:GridView>
       </div>
   </div>
</asp:Content>
