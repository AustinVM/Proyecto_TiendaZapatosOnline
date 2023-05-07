using CapaDatos.Conexion;
using CapaEntidades.UsuarioSistema;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.UsuarioSistema
{
    public class Cd_Rol
    {
        public void AgregarRol(Ce_Rol AgregarRol) // Inicio del metodo para agregar un rol
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_AgregarRol", conex))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", AgregarRol.idRol);
                        cmd.Parameters.AddWithValue("@nombre", AgregarRol.nombreRol);
                        cmd.Parameters.AddWithValue("@estado", AgregarRol.estadoRol);
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
        } // Fin del metodo para agregar un rol

        public DataTable ConsultarRol() // Inicio del metodo de consultar rol (trae todos los roles de la base de datos)
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
        } // Fin del metodo de consultar rol

        public void ActualizarRol(Ce_Rol ActualizarRol) // Inicio del metodo para actualizar un rol
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
        } // Fin del metodo para actualizar un rol

        public void EliminarRol(Ce_Rol EliminarRol) // Inicio del metodo para eliminar un rol
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
        } // Fin del metodo para eliminar un rol
    }
}