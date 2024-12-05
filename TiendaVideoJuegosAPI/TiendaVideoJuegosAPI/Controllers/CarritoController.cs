using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;
using TiendaVideoJuegosAPI.Helpers;

namespace TiendaVideojuegosAPI.Controllers
{
    public class CarritoController : ApiController
    {
        private readonly DbHelper dbHelper;

        public CarritoController()
        {
            dbHelper = new DbHelper(System.Configuration.ConfigurationManager.ConnectionStrings["TiendaVideojuegosDB"].ConnectionString);
        }

        [HttpGet]
        [Route("api/Carrito")]
        public IHttpActionResult GetCarrito()
        {
            string query = "SELECT * FROM Carrito";
            DataTable result = dbHelper.ExecuteQuery(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/Carrito/{id}")]
        public IHttpActionResult GetCarritoById(int id)
        {
            string query = "SELECT * FROM Carrito WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            DataTable result = dbHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [Route("api/Carrito")]
        public IHttpActionResult PostCarrito(dynamic carrito)
        {
            string query = "INSERT INTO Carrito (UsuarioId, ProductoId, Cantidad) VALUES (@UsuarioId, @ProductoId, @Cantidad)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UsuarioId", (int)carrito.UsuarioId),
                new SqlParameter("@ProductoId", (int)carrito.ProductoId),
                new SqlParameter("@Cantidad", (int)carrito.Cantidad)
            };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Producto agregado al carrito exitosamente.");

            return BadRequest("Error al agregar el producto al carrito.");
        }

        [HttpPut]
        [Route("api/Carrito/{id}")]
        public IHttpActionResult PutCarrito(int id, dynamic carrito)
        {
            string query = "UPDATE Carrito SET UsuarioId = @UsuarioId, ProductoId = @ProductoId, Cantidad = @Cantidad WHERE Id = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@UsuarioId", (int)carrito.UsuarioId),
                new SqlParameter("@ProductoId", (int)carrito.ProductoId),
                new SqlParameter("@Cantidad", (int)carrito.Cantidad)
            };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Carrito actualizado exitosamente.");

            return BadRequest("Error al actualizar el carrito.");
        }

        [HttpDelete]
        [Route("api/Carrito/{id}")]
        public IHttpActionResult DeleteCarrito(int id)
        {
            string query = "DELETE FROM Carrito WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Producto eliminado del carrito exitosamente.");

            return BadRequest("Error al eliminar el producto del carrito.");
        }
    }
}
