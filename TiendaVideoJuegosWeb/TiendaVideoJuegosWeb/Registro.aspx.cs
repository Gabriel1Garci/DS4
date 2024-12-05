using System;
using System.Net.Http;
using System.Text;
using System.Web.UI;

namespace TiendaVideojuegosWeb
{
    public partial class Registro : Page
    {
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Por favor, complete todos los campos.";
                return;
            }

            string apiUrl = "https://localhost:44334/api/Usuarios";
            string jsonData = $"{{\"Nombre\":\"{nombre}\",\"Apellido\":\"{apellido}\",\"Correo\":\"{email}\",\"Contraseña\":\"{password}\"}}";

            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    lblMessage.Text = "Usuario registrado exitosamente.";
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    lblMessage.Text = "Error al registrar el usuario.";
                }
            }
        }
    }
}
