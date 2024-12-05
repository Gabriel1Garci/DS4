using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace ClubNauticoApp
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Opcional: Inicializar datos o cargar todo el reporte sin filtros.
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Obtener la cadena de conexión desde Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["ClubNauticoConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Consulta con parámetros
                string query = "SELECT * FROM Salidas WHERE FechaSalida BETWEEN @FechaInicio AND @FechaFin AND Destino LIKE @Destino";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Asignar valores a los parámetros
                cmd.Parameters.AddWithValue("@FechaInicio", txtFechaInicio.Text);
                cmd.Parameters.AddWithValue("@FechaFin", txtFechaFin.Text);
                cmd.Parameters.AddWithValue("@Destino", "%" + txtDestino.Text + "%");

                conn.Open();

                // Ejecutar y enlazar los datos al GridView
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();

                conn.Close();
            }
        }
    }
}
