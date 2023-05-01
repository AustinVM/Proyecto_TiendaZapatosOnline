using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Usuario
    {
        public void AniadirUsuario(Ce_Usuario AniadirUsuario)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", AniadirUsuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@contrasenia", AniadirUsuario.ContraseniaUsuario);
                        cmd.Parameters.AddWithValue("@ID_rol", AniadirUsuario.ID_rol);
                        cmd.Parameters.AddWithValue("@estado", AniadirUsuario.EstadoUsuario);
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
        }

        public List<Ce_Usuario> ConsultarUsuario()
        {
            List<Ce_Usuario> listaUsuarios = new List<Ce_Usuario>();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ConsultarUsuario", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader leer = cmd.ExecuteReader();
                        while (leer.Read())
                        {
                            Ce_Usuario DatosUsuarios = new Ce_Usuario();
                            DatosUsuarios.id = leer.GetInt32(0);
                            DatosUsuarios.NombreUsuario = leer.GetString(1);
                            DatosUsuarios.ContraseniaUsuario = leer.GetString(2);
                            DatosUsuarios.ID_rol = leer.GetInt32(3);
                            DatosUsuarios.EstadoUsuario = leer.GetBoolean(4);
                            listaUsuarios.Add(DatosUsuarios);
                        }
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
        }

        public void ActualizarUsuario(Ce_Usuario ActualizarUsuario)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("", conex))
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
        }

        public void EliminarUsuario(Ce_Usuario EliminarUsuario)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", EliminarUsuario.id);
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
        }
    }
}