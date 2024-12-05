using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;
using TiendaVideoJuegosAPI.Helpers;

namespace TiendaVideojuegosAPI.Controllers
{
    public class ComprasController : ApiController
    {
        private readonly DbHelper dbHelper;

        public ComprasController()
        {
            dbHelper = new DbHelper(System.Configuration.ConfigurationManager.ConnectionStrings["TiendaVideojuegosDB"].ConnectionString);
        }

        [HttpGet]
        [Route("api/Compras")]
        public IHttpActionResult GetCompras()
        {
            string query = "SELECT * FROM Compras";
            DataTable result = dbHelper.ExecuteQuery(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/Compras/{id}")]
        public IHttpActionResult GetCompra(int id)
        {
            string query = "SELECT * FROM Compras WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            DataTable result = dbHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [Route("api/Compras")]
        public IHttpActionResult PostCompra(dynamic compra)
        {
            string query = "INSERT INTO Compras (UsuarioId, Total) VALUES (@UsuarioId, @Total)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UsuarioId", (int)compra.UsuarioId),
                new SqlParameter("@Total", (decimal)compra.Total)
            };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Compra registrada exitosamente.");

            return BadRequest("Error al registrar la compra.");
        }

        [HttpDelete]
        [Route("api/Compras/{id}")]
        public IHttpActionResult DeleteCompra(int id)
        {
            string query = "DELETE FROM Compras WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Compra eliminada exitosamente.");

            return BadRequest("Error al eliminar la compra.");
        }
    }
}
