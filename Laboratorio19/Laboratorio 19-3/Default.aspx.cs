using System;
using System.IO;
using System.Net;
using System.Web.UI;

namespace Laboratorio_19_3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string GetValueById(int id)
        {
            // URL ajustada para obtener el valor por ID
            var url = $"https://localhost:44355/api/values/2";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string responseBody = reader.ReadToEnd();
                        return responseBody;
                    }
                }
            }
            catch (WebException ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        protected void btnGetById_Click(object sender, EventArgs e)
        {
            // Llama al método para obtener el valor con ID 2
            lblResult.Text = GetValueById(2);
        }
    }
}

