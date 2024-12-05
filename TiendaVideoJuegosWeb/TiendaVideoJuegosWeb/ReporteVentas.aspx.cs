using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaVideoJuegosWeb
{
    public partial class ReporteVentas : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RegisterAsyncTask(new PageAsyncTask(CargarVentas));
            }
        }

        private async Task CargarVentas()
        {
            string apiUrl = "https://localhost:44334/api/Compras"; // URL de la API local
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    var ventas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dynamic>>(json);

                    if (ventas != null && ventas.Count > 0)
                    {
                        RepeaterVentas.DataSource = ventas;
                        RepeaterVentas.DataBind();
                    }
                    else
                    {
                        LiteralMensaje.Text = "<p>No se encontraron ventas.</p>";
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                LiteralMensaje.Text = $"<p>Error de solicitud HTTP: {ex.Message}</p>";
            }
            catch (Exception ex)
            {
                LiteralMensaje.Text = $"<p>Error al cargar ventas: {ex.Message}</p>";
            }
        }
    }
}