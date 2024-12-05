using System;
using System.Data.SqlClient;
using System.Configuration;

namespace ClubNauticoApp
{
    public partial class RegistrarBarco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

        protected void btnRegistrarBarco_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClubNauticoConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Barcos (NumeroMatricula, Nombre, NumeroAmarre, Cuota, SocioId) VALUES (@Matricula, @Nombre, @Amarre, @Cuota, @SocioId)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombreBarco.Text);
                cmd.Parameters.AddWithValue("@Amarre", txtNumeroAmarre.Text);
                cmd.Parameters.AddWithValue("@Cuota", txtCuota.Text);
                cmd.Parameters.AddWithValue("@SocioId", ddlSocios.SelectedValue);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    txtMatricula.Text = txtNombreBarco.Text = txtNumeroAmarre.Text = txtCuota.Text = "";
                    Response.Write("<script>alert('Barco registrado exitosamente.');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }
        }
    }
}
