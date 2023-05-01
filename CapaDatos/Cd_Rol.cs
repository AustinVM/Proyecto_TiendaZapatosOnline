using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Rol
    {
        public void AniadirRol(Ce_Rol AniadirRol)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", AniadirRol.idRol);
                    cmd.Parameters.AddWithValue("@nombre", AniadirRol.nombreRol);
                    cmd.Parameters.AddWithValue("@estado", AniadirRol.estadoRol);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarRol()
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("", conex))
                {
                    DataTable tabla = new DataTable();
                    SqlDataReader leer;
                    cmd.CommandType = CommandType.StoredProcedure;
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        public void ActualizarRol(Ce_Rol ActualizarRol)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ActualizarRol.idRol);
                    cmd.Parameters.AddWithValue("@nombre", ActualizarRol.nombreRol);
                    cmd.Parameters.AddWithValue("@estado", ActualizarRol.estadoRol);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarRol(Ce_Rol EliminarRol)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", EliminarRol.idRol);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}