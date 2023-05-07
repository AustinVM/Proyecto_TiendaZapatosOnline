using CapaDatos.Conexion;
using CapaEntidades.UsuarioSistema;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.UsuarioSistema
{
    public class Cd_Rol
    {
        public void AniadirRol(Ce_Rol AniadirRol)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_AniadirRol", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", AniadirRol.idRol);
                        cmd.Parameters.AddWithValue("@nombre", AniadirRol.nombreRol);
                        cmd.Parameters.AddWithValue("@estado", AniadirRol.estadoRol);
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

        public DataTable ConsultarRol()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ConsultarRol", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader leer = cmd.ExecuteReader();
                        tabla.Load(leer);
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
                return tabla;
            }
        }

        public void ActualizarRol(Ce_Rol ActualizarRol)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ActualizarRol", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", ActualizarRol.idRol);
                        cmd.Parameters.AddWithValue("@nombre", ActualizarRol.nombreRol);
                        cmd.Parameters.AddWithValue("@estado", ActualizarRol.estadoRol);
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

        public void EliminarRol(Ce_Rol EliminarRol)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_EliminarRol", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", EliminarRol.idRol);
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