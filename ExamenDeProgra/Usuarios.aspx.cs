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
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGridView();
            }
        }

        protected void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtCorreoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtTelefonoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text.Trim();
            string correo = txtCorreoUsuario.Text.Trim();
            string telefono = txtTelefonoUsuario.Text.Trim();

            InsertarUsuario(nombre, correo, telefono);

            LlenarGridView();
        }

        protected void gridUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LlenarGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UUSUARIOSS";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        gridUsuarios.DataSource = dt;
                        gridUsuarios.DataBind();
                    }
                }
            }
        }
        private void InsertarUsuario(string nombre, string correo, string telefono)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UUSUARIOSS(Nombre, CorreoElectronico, Telefono) VALUES (@Nombre, @Correo, @Telefono)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}