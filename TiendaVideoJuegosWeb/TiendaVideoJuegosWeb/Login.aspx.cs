using System;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Web.UI;

namespace TiendaVideojuegosWeb
{
    public partial class Login : Page
    {
        protected async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    lblMessage.Text = "Por favor, ingrese todos los campos.";
                    return;
                }

                string apiUrl = "https://localhost:5001/api/Usuarios/Login";
                string jsonData = $"{{\"Correo\":\"{email}\",\"Contraseña\":\"{password}\"}}";

                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        lblMessage.Text = "Inicio de sesión exitoso.";
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        lblMessage.Text = $"Error de autenticación. Código: {response.StatusCode}, Mensaje: {responseBody}";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error inesperado: {ex.Message}";
                System.Diagnostics.Debug.WriteLine($"Error en login: {ex.Message}");
            }
        }
    }
}