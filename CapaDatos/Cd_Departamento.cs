using CapaDatos.Conexion;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Departamento
    {
        public void AgregarDepartamento(Ce_Departamento AgregarDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("AgregarDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", AgregarDepartamento.nombre);
                    cmd.Parameters.AddWithValue("@estado", AgregarDepartamento.estado);
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

        public void ActualizarDepartamento(Ce_Departamento ActualizarDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ActualizarDepartamento.id);
                    cmd.Parameters.AddWithValue("@nombre", ActualizarDepartamento.nombre);
                    cmd.Parameters.AddWithValue("@estado", ActualizarDepartamento.estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarDepartamento(Ce_Departamento EliminarDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", EliminarDepartamento.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
