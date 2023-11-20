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
    public partial class Detalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarDetallesReparacion();
            }
        }

        protected void txtReparacionID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtFechaFin_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                int reparacionID = Convert.ToInt32(txtReparacionID.Text);
                string descripcion = txtDescripcion.Text;
                DateTime fechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
                DateTime? fechaFin = string.IsNullOrEmpty(txtFechaFin.Text) ? (DateTime?)null : Convert.ToDateTime(txtFechaFin.Text);

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString))
                {
                    con.Open();
                    string query = "INSERT INTO DDetallesReparacioNN (ReparacionID, Descripcion, FechaInicic, FechaFin) VALUES (@ReparacionID, @Descripcion, @FechaInicio, @FechaFin)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", (object)fechaFin ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                
                CargarDetallesReparacion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el detalle: " + ex.Message);
               
            }
        }

        protected void gridDetallesReparacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarDetallesReparacion()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString))
            {
                con.Open();
                string query = "SELECT DetallelD, ReparacionID, Descripcion, FechaInicic, FechaFin FROM DDetallesReparacioNN";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gridDetallesReparacion.DataSource = dt;
                        gridDetallesReparacion.DataBind();
                    }
                }
            }
        }
    }
}