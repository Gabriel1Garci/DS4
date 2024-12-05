using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.Http;
using TiendaVideoJuegosAPI.Helpers;

namespace TiendaVideoJuegosAPI.Controllers
{
    public class CategoriasController : ApiController
    {
        private readonly DbHelper dbHelper;

            public CategoriasController()
            {
                dbHelper = new DbHelper(System.Configuration.ConfigurationManager.ConnectionStrings["TiendaVideojuegosDB"].ConnectionString);
            }

            [HttpGet]
            [Route("api/Categorias")]
            public IHttpActionResult GetCategorias()
            {
                string query = "SELECT * FROM Categorias";
                DataTable result = dbHelper.ExecuteQuery(query);
                return Ok(result);
            }

            [HttpGet]
            [Route("api/Categorias/{id}")]
            public IHttpActionResult GetCategoria(int id)
            {
                string query = "SELECT * FROM Categorias WHERE Id = @Id";
                SqlParameter[] parameters = { new SqlParameter("@Id", id) };
                DataTable result = dbHelper.ExecuteQuery(query, parameters);
                if (result.Rows.Count == 0)
                    return NotFound();

                return Ok(result);
            }

            [HttpPost]
            [Route("api/Categorias")]
            public IHttpActionResult PostCategoria(dynamic categoria)
            {
                string query = "INSERT INTO Categorias (Nombre) VALUES (@Nombre)";
                SqlParameter[] parameters = { new SqlParameter("@Nombre", (string)categoria.Nombre) };

                int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                    return Ok("Categoría agregada exitosamente.");

                return BadRequest("Error al agregar la categoría.");
            }

            [HttpPut]
            [Route("api/Categorias/{id}")]
            public IHttpActionResult PutCategoria(int id, dynamic categoria)
            {
                string query = "UPDATE Categorias SET Nombre = @Nombre WHERE Id = @Id";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Id", id),
                    new SqlParameter("@Nombre", (string)categoria.Nombre)
                };

                int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                    return Ok("Categoría actualizada exitosamente.");

                return BadRequest("Error al actualizar la categoría.");
            }

            [HttpDelete]
            [Route("api/Categorias/{id}")]
            public IHttpActionResult DeleteCategoria(int id)
            {
                string query = "DELETE FROM Categorias WHERE Id = @Id";
                SqlParameter[] parameters = { new SqlParameter("@Id", id) };

                int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                    return Ok("Categoría eliminada exitosamente.");

                return BadRequest("Error al eliminar la categoría.");
            }
    }
}