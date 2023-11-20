using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenDeProgra
{
    public partial class Equipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGridView();
            }
        }

        protected void txtTipoEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtModeloEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            string tipoEquipo = txtTipoEquipo.Text.Trim();
            string modelo = txtModeloEquipo.Text.Trim();

            // Insertar nuevo equipo en la base de datos
            InsertarEquipo(tipoEquipo, modelo);

            // Volver a cargar el GridView con los datos actualizados
            LlenarGridView();
        }
        private void LlenarGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM EEquipoSS";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Llenar el GridView con los resultados
                        gridEquipos.DataSource = dt;
                        gridEquipos.DataBind();
                    }
                }
            }
        }
        private void InsertarEquipo(string tipoEquipo, string modelo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO EEquipoSS (TipoEquipo, Modelo) VALUES (@TipoEquipo, @Modelo)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TipoEquipo", tipoEquipo);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        protected void gridEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtTipoEquipo_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void gridEquipos_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void gridEquipos_SelectedIndexChanged2(object sender, EventArgs e)
        {

        }
    }
}