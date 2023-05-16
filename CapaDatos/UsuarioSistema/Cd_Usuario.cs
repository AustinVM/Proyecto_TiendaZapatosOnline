using CapaDatos.Conexion;
using CapaEntidades.UsuarioSistema;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.UsuarioSistema
{
    public class Cd_Usuario
    {
        public static void AgregarUsuario(Ce_Usuario AgregarUsuario)
        {
            using SqlConnection conex = new(Cd_Conexion._rutaBaseDatos);
            try
            {
                conex.Open();
                using SqlCommand cmd = new("SP_AgregarUsuario", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", AgregarUsuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@contrasenia", AgregarUsuario.ContraseniaUsuario);
                cmd.Parameters.AddWithValue("@ID_rol", AgregarUsuario.Id_Rol);
                cmd.Parameters.AddWithValue("@estado", AgregarUsuario.EstadoUsuario);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine("Ocurrio un error con la base de datos." + SqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error." + ex.Message);
            }
        }

        public List<Ce_Usuario> ConsultarUsuario()
        {
            List<Ce_Usuario> listaUsuarios = new();
            using SqlConnection conex = new(Cd_Conexion._rutaBaseDatos);
            try
            {
                conex.Open();
                using SqlCommand cmd = new("SP_ConsultarUsuario", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    Ce_Usuario DatosUsuarios = new()
                    {
                        Id = leer.GetInt32(0),
                        NombreUsuario = leer.GetString(1),
                        ContraseniaUsuario = leer.GetString(2),
                        Id_Rol = leer.GetInt32(3),
                        EstadoUsuario = leer.GetBoolean(4)
                    };
                    listaUsuarios.Add(DatosUsuarios);
                }
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine("Ocurrio un error con la base de datos." + SqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error." + ex.Message);
            }
            return listaUsuarios;
        }

        public static void ActualizarUsuario(Ce_Usuario ActualizarUsuario)
        {
            using SqlConnection conex = new(Cd_Conexion._rutaBaseDatos);
            try
            {
                conex.Open();
                using (SqlCommand cmd = new("SP_ActualizarUsuario", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", ActualizarUsuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@estado", ActualizarUsuario.EstadoUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine("Ocurrio un error con la base de datos." + SqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error." + ex.Message);
            }
        }

        public static void EliminarUsuario(Ce_Usuario EliminarUsuario)
        {
            using SqlConnection conex = new(Cd_Conexion._rutaBaseDatos);
            try
            {
                conex.Open();
                using SqlCommand cmd = new("SP_EliminarUsuario", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", EliminarUsuario.Id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine("Ocurrio un error con la base de datos." + SqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error." + ex.Message);
            }
        }
    }
}