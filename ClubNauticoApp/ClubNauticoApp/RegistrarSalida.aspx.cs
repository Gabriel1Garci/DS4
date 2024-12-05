using System;
using System.Data.SqlClient;
using System.Configuration;

namespace ClubNauticoApp
{
    public partial class RegistrarSalida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cargar los datos en los dropdowns
            if (!IsPostBack)
            {
                CargarBarcos();
                CargarPatrones();
            }
        }

        private void CargarBarcos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClubNauticoConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT BarcoId, Nombre FROM Barcos";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                ddlBarcos.DataSource = reader;
                ddlBarcos.DataTextField = "Nombre"; 
                ddlBarcos.DataValueField = "BarcoId";
                ddlBarcos.DataBind();

                conn.Close();
            }
        }

        private void CargarPatrones()
        {
            if (!IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ClubNauticoConnectionString"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT SocioId, Nombre + ' ' + Apellido AS NombreCompleto FROM Socios";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    ddlSocios.DataSource = reader;
                    ddlSocios.DataTextField = "NombreCompleto";
                    ddlSocios.DataValueField = "SocioId";
                    ddlSocios.DataBind();

                    conn.Close();
                }
            }
        }

        protected void btnRegistrarSalida_Click(object sender, EventArgs e)
        {

            string barcoId = ddlBarcos.SelectedValue;
            string fecha = txtFechaSalida.Text;
            string hora = txtHoraSalida.Text;
            string destino = txtDestino.Text;
            string patronId = ddlSocios.SelectedValue;

            string connectionString = ConfigurationManager.ConnectionStrings["ClubNauticoConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Salidas (BarcoId, Fecha, Hora, Destino, PatronId) VALUES (@BarcoId, @Fecha, @Hora, @Destino, @PatronId)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@BarcoId", barcoId);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Hora", hora);
                cmd.Parameters.AddWithValue("@Destino", destino);
                cmd.Parameters.AddWithValue("@PatronId", patronId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    txtFechaSalida.Text = txtHoraSalida.Text = txtDestino.Text = "";
                    Response.Write("<script>alert('Salida registrada exitosamente.');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }
        }
    }
}
