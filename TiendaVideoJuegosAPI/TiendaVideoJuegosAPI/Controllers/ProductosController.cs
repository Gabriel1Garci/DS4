using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Web.Http;
using TiendaVideoJuegosAPI.Helpers;

namespace TiendaVideoJuegosAPI.Controllers
{
    public class ProductosController : ApiController
    {
        private readonly DbHelper dbHelper;

        public ProductosController()
        {
            // Usar la cadena de conexión definida en Web.config
            dbHelper = new DbHelper(System.Configuration.ConfigurationManager.ConnectionStrings["TiendaVideojuegosDB"].ConnectionString);
        }

        [HttpGet]
        [Route("api/Productos")]
        public IHttpActionResult GetProductos()
        {
            string query = "SELECT * FROM Productos";
            DataTable result = dbHelper.ExecuteQuery(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/Productos/{id}")]
        public IHttpActionResult GetProducto(int id)
        {
            string query = "SELECT * FROM Productos WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            DataTable result = dbHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [Route("api/Productos")]
        public IHttpActionResult PostProducto(dynamic producto)
        {
            string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock) VALUES (@Nombre, @Descripcion, @Precio, @Stock)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nombre", (string)producto.Nombre),
                new SqlParameter("@Descripcion", (string)producto.Descripcion),
                new SqlParameter("@Precio", (decimal)producto.Precio),
                new SqlParameter("@Stock", (int)producto.Stock),
            };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Producto agregado exitosamente.");

            return BadRequest("Error al agregar el producto.");
        }

        [HttpPut]
        [Route("api/Productos/{id}")]
        public IHttpActionResult PutProducto(int id, dynamic producto)
        {
            string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock, Imagen = @Imagen, CategoriaId = @CategoriaId WHERE Id = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@Nombre", (string)producto.Nombre),
                new SqlParameter("@Descripcion", (string)producto.Descripcion),
                new SqlParameter("@Precio", (decimal)producto.Precio),
                new SqlParameter("@Stock", (int)producto.Stock),
                new SqlParameter("@Imagen", (string)producto.Imagen),
                new SqlParameter("@CategoriaId", (int)producto.CategoriaId)
            };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Producto actualizado exitosamente.");

            return BadRequest("Error al actualizar el producto.");
        }

        [HttpDelete]
        [Route("api/Productos/{id}")]
        public IHttpActionResult DeleteProducto(int id)
        {
            string query = "DELETE FROM Productos WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Producto eliminado exitosamente.");

            return BadRequest("Error al eliminar el producto.");
        }
    }
}