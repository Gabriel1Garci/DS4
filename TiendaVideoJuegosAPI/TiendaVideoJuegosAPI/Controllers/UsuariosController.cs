using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;
using TiendaVideoJuegosAPI.Helpers;

namespace TiendaVideoJuegosAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly DbHelper dbHelper;

        public UsuariosController()
        {
            dbHelper = new DbHelper(System.Configuration.ConfigurationManager.ConnectionStrings["TiendaVideojuegosDB"].ConnectionString);
        }

        [HttpGet]
        [Route("api/Usuarios")]
        public IHttpActionResult GetUsuarios()
        {
            string query = "SELECT Id, Nombre, Apellido, Correo FROM Usuarios"; // No devolver contraseñas
            DataTable result = dbHelper.ExecuteQuery(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/Usuarios/{id}")]
        public IHttpActionResult GetUsuario(int id)
        {
            string query = "SELECT Id, Nombre, Apellido, Correo FROM Usuarios WHERE Id = @Id"; // No devolver contraseñas
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            DataTable result = dbHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [Route("api/Usuarios")]
        public IHttpActionResult PostUsuario(dynamic usuario)
        {
            try
            {
                string hashedPassword = HashPassword((string)usuario.Contraseña);

                string query = "INSERT INTO Usuarios (Nombre, Apellido, Correo, Contraseña) VALUES (@Nombre, @Apellido, @Correo, @Contraseña)";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Nombre", (string)usuario.Nombre),
                    new SqlParameter("@Apellido", (string)usuario.Apellido),
                    new SqlParameter("@Correo", (string)usuario.Correo),
                    new SqlParameter("@Contraseña", hashedPassword)
                };

                int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                    return Ok("Usuario registrado exitosamente.");

                return BadRequest("Error al registrar el usuario.");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("api/Usuarios/Login")]
        public IHttpActionResult Login(dynamic loginData)
        {
            try
            {
                string correo = (string)loginData.Correo;
                string password = (string)loginData.Contraseña;

                string query = "SELECT Contraseña FROM Usuarios WHERE Correo = @Correo";
                SqlParameter[] parameters = { new SqlParameter("@Correo", correo) };

                DataTable result = dbHelper.ExecuteQuery(query, parameters);
                if (result.Rows.Count == 0)
                    return Unauthorized(); // Usuario no encontrado

                string storedPasswordHash = result.Rows[0]["Contraseña"].ToString();

                if (VerifyPassword(password, storedPasswordHash))
                {
                    return Ok("Inicio de sesión exitoso.");
                }
                else
                {
                    return Unauthorized(); // Contraseña incorrecta
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            string hashedPassword = HashPassword(password);
            return hashedPassword == storedHash;
        }

        [HttpPut]
        [Route("api/Usuarios/{id}")]
        public IHttpActionResult PutUsuario(int id, dynamic usuario)
        {
            try
            {
                string hashedPassword = HashPassword((string)usuario.Contraseña);

                string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Contraseña = @Contraseña WHERE Id = @Id";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Id", id),
                    new SqlParameter("@Nombre", (string)usuario.Nombre),
                    new SqlParameter("@Apellido", (string)usuario.Apellido),
                    new SqlParameter("@Correo", (string)usuario.Correo),
                    new SqlParameter("@Contraseña", hashedPassword)
                };

                int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                    return Ok("Usuario actualizado exitosamente.");

                return BadRequest("Error al actualizar el usuario.");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("api/Usuarios/{id}")]
        public IHttpActionResult DeleteUsuario(int id)
        {
            string query = "DELETE FROM Usuarios WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return Ok("Usuario eliminado exitosamente.");

            return BadRequest("Error al eliminar el usuario.");
        }
    }
}
