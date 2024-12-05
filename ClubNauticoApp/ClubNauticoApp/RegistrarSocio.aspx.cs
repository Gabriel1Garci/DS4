using System;
using System.Data.SqlClient;

namespace ClubNauticoApp
{
    public partial class RegistrarSocio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClubNauticoConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Socios (Nombre, Apellido, Telefono, Email) VALUES (@Nombre, @Apellido, @Telefono, @Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Response.Write("<script>alert('Socio registrado exitosamente');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }
        }
    }
}