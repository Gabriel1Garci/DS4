using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio171
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                // Obtiene la cadena de conexión desde el Web.config
                ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConexionNorthwind"];
                using (SqlConnection conexion = new SqlConnection(connString.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SalesByCategory", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = "Seafood";

                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                GridV.DataSource = dt;
                                GridV.DataBind();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Response.Write($"Error: {ex.Message}");
            }
        }
    }
}
