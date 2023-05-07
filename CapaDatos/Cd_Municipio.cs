using CapaDatos.Conexion;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Municipio
    {
        public void AggMunicipio(Ce_Municipio AggMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", AggMunicipio.nombre);
                    cmd.Parameters.AddWithValue("@id_Departamento", AggMunicipio.id_Departamento);
                    cmd.Parameters.AddWithValue("@estado", AggMunicipio.estado);
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

        public void ActMunicipio(Ce_Municipio ActMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ActMunicipio.id);
                    cmd.Parameters.AddWithValue("@nombre", ActMunicipio.nombre);
                    cmd.Parameters.AddWithValue("@estado", ActMunicipio.estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ElimMunicipio(Ce_Municipio ElimMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ElimMunicipio.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
