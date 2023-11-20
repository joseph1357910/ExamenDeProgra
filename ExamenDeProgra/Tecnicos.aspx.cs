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
    public partial class Tecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGridView();
            }
        }

        protected void txtNombreTecnico_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEspecialidadTecnico_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardarTecnico_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreTecnico.Text.Trim();
            string especialidad = txtEspecialidadTecnico.Text.Trim();

            InsertarTecnico(nombre, especialidad);
            LlenarGridView();
        }

        protected void gridTecnicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InsertarTecnico(string nombre, string especialidad)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TTecnicoSS (Nombre, Especialidad) VALUES (@Nombre, @Especialidad)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Especialidad", especialidad);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
        private void LlenarGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TTecnicoSS";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        gridTecnicos.DataSource = dt;
                        gridTecnicos.DataBind();
                    }
                }
            }
        }
    }
}