using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVideoJuegosWeb.Helpers
{
    public class ApiHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> PostAsync(string url, string jsonData)
        {
            HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> PutAsync(string url, string jsonData)
        {
            HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteAsync(string url)
        {
            HttpResponseMessage response = await client.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}