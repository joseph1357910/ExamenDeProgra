using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenDeProgra
{
    public partial class Reparaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void txtUsuarioID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEquipoID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregarReparacion_Click(object sender, EventArgs e)
        {
            int usuarioID = Convert.ToInt32(txtUsuarioID.Text);
            int equipoID = Convert.ToInt32(txtEquipoID.Text);
            DateTime fechaSolicitud = Convert.ToDateTime(txtFechaSolicitud.Text);
            char estado = Convert.ToChar(txtEstado.Text.Substring(0, 1));



            
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO RReparacioneSS (UsuarioID, EquipoID, FechaSolicitud, Estado) VALUES (@UsuarioID, @EquipoID, @FechaSolicitud, @Estado)", con);
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                    cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud);
                    cmd.Parameters.AddWithValue("@Estado", estado);

                    cmd.ExecuteNonQuery();
                    LimpiarCampos();
                    LlenarGridView();
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        protected void gridReparaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LlenarGridView()
        {
            
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM RReparacioneSS", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    gridReparaciones.DataSource = dt;
                    gridReparaciones.DataBind();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                }
            }
        }
        private void LimpiarCampos()
        {
        }

    }
}