using CapaDatos.Conexion;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Municipio
    {
        public void AgregarMunicipio(Ce_Municipio AgregarMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AgregarMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", AgregarMunicipio.nombre);
                    cmd.Parameters.AddWithValue("@id_Departamento", AgregarMunicipio.id_Departamento);
                    cmd.Parameters.AddWithValue("@estado", AgregarMunicipio.estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarMunicipio(Ce_Municipio ConsultarMunicipio)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarMunicipio", conex))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    cmd.Parameters.AddWithValue("@id_Departamento", ConsultarMunicipio.id_Departamento);
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void ActualizarMunicipio(Ce_Municipio ActualizarMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ActualizarMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ActualizarMunicipio.id);
                    cmd.Parameters.AddWithValue("@nombre", ActualizarMunicipio.nombre);
                    cmd.Parameters.AddWithValue("@estado", ActualizarMunicipio.estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarMunicipio(Ce_Municipio EliminarMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_EliminarMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", EliminarMunicipio.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
