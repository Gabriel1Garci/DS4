using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;

public partial class Productos : Page
{
    protected async void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            await CargarCategorias();
        }
    }

    private async Task CargarCategorias()
    {
        string apiUrl = "https://localhost:44334/api/Categorias";
        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var categorias = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dynamic>>(json);

                ddlCategorias.DataSource = categorias;
                ddlCategorias.DataTextField = "Nombre";
                ddlCategorias.DataValueField = "Id";
                ddlCategorias.DataBind();

                ddlCategorias.Items.Insert(0, new System.Web.UI.WebControls.ListItem("-- Seleccionar Categoría --", ""));
            }
        }
        catch (Exception ex)
        {
            // Manejar errores (mostrar mensaje, registrar en logs, etc.)
            Console.WriteLine($"Error al cargar categorías: {ex.Message}");
        }
    }

    protected async void ddlCategorias_SelectedIndexChanged(object sender, EventArgs e)
    {
        string categoriaId = ddlCategorias.SelectedValue;
        if (string.IsNullOrEmpty(categoriaId)) return;

        string apiUrl = $"https://localhost:44334/api/Productos?categoriaId={categoriaId}";
        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var productos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dynamic>>(json);

                RepeaterProductos.DataSource = productos;
                RepeaterProductos.DataBind();
            }
        }
        catch (Exception ex)
        {
            // Manejar errores (mostrar mensaje, registrar en logs, etc.)
            Console.WriteLine($"Error al cargar productos: {ex.Message}");
        }
    }
}
