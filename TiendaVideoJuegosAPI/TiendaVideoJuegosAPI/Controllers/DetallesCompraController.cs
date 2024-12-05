using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;
using TiendaVideoJuegosAPI.Helpers;

namespace TiendaVideojuegosAPI.Controllers
{
    public class DetallesCompraController : ApiController
    {
        private readonly DbHelper dbHelper;

        public DetallesCompraController()
        {
            dbHelper = new DbHelper(System.Configuration.ConfigurationManager.ConnectionStrings["TiendaVideojuegosDB"].ConnectionString);
        }

        [HttpGet]
        [Route("api/DetallesCompra")]
        public IHttpActionResult GetDetallesCompra()
        {
            string query = "SELECT * FROM DetallesCompra";
            DataTable result = dbHelper.ExecuteQuery(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/DetallesCompra/{id}")]
        public IHttpActionResult GetDetalleCompra(int id)
        {
            string query = "SELECT * FROM DetallesCompra WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            DataTable result = dbHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [Route("api/DetallesCompra")]
        public IHttpActionResult PostDetalleCompra(dynamic detalle)
        {
            string query = "INSERT INTO DetallesCompra (CompraId, ProductoId, Cantidad, PrecioUnitario, Subtotal) VALUES (@CompraId, @ProductoId, @Cantidad, @PrecioUnitario, @Subtotal)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@CompraId", (int)detalle.CompraId),
                new SqlParameter("@ProductoId", (int)detalle.ProductoId),
                new SqlParameter("@Cantidad", (int)detalle.Cantidad),
                new SqlParameter("@PrecioUnitario", (decimal)detalle.PrecioUnitario),
                new SqlParameter("@Subtotal", (decimal)detalle.Subtotal)
            };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Detalle de compra registrado exitosamente.");

            return BadRequest("Error al registrar el detalle de compra.");
        }

        [HttpDelete]
        [Route("api/DetallesCompra/{id}")]
        public IHttpActionResult DeleteDetalleCompra(int id)
        {
            string query = "DELETE FROM DetallesCompra WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Detalle de compra eliminado exitosamente.");

            return BadRequest("Error al eliminar el detalle de compra.");
        }
    }
}
