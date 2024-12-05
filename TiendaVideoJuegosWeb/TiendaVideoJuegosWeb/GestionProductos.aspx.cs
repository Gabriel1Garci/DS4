using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using TiendaVideoJuegosWeb.Helpers;

namespace TiendaVideoJuegosWeb
{
    public partial class GestionProductos : Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                await CargarProductos();
            }
        }

        private async Task CargarProductos()
        {
            string apiUrl = "https://localhost:44334/api/Productos"; // Endpoint de productos
            using (HttpClient client = new HttpClient())
            {
                // Aumentar el tiempo de espera a 30 segundos
                client.Timeout = TimeSpan.FromSeconds(30);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var productos = await response.Content.ReadAsAsync<List<Producto>>();
                        gvProductos.DataSource = productos;
                        gvProductos.DataBind();
                    }
                    else
                    {
                        lblMessage.Text = "No se pudieron cargar los productos.";
                    }
                }
                catch (TaskCanceledException)
                {
                    lblMessage.Text = "La solicitud ha tardado demasiado. Por favor, inténtelo de nuevo más tarde.";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = $"Error al cargar productos: {ex.Message}";
                }
            }
        }


        protected async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de datos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                    !decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                    !int.TryParse(txtStock.Text, out int stock))
                {
                    lblMessage.Text = "Por favor, llena todos los campos correctamente.";
                    return;
                }

                // Crear objeto JSON
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = precio,
                    Stock = stock
                };
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(producto);

                string apiUrl = "https://localhost:44334/api/Productos";
                string response = await ApiHelper.PostAsync(apiUrl, jsonData);

                lblMessage.Text = "Producto guardado correctamente.";
                await CargarProductos();
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error al guardar producto: {ex.Message}";
            }
        }

        public class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }
        }
    }

    // API Helper Implementation (ensure this is in the correct place)
    public static class ApiHelper
    {
        public static async Task<string> PostAsync(string url, string jsonData)
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}

