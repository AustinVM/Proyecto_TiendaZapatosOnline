using CapaDatos.Conexion;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Departamento
    {
        public void AggDepartamento(Ce_Departamento AggDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", AggDepartamento.nombre);
                    cmd.Parameters.AddWithValue("@estado", AggDepartamento.estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarDepartamento()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarDepartamento", conex))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void ActDepartamento(Ce_Departamento ActDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ActDepartamento.id);
                    cmd.Parameters.AddWithValue("@nombre", ActDepartamento.nombre);
                    cmd.Parameters.AddWithValue("@estado", ActDepartamento.estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ElimDepartamento(Ce_Departamento ElimDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ElimDepartamento.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
