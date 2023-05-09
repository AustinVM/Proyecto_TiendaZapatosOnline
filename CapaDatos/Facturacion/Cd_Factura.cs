using CapaDatos.Conexion;
using CapaEntidades.Facturacion;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Cd_Factura
    {
        public void AgregarFactura(Ce_Factura AgregarFactura)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AgregarFactura", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FchExpedicion", AgregarFactura.FchExpedicion);
                    cmd.Parameters.AddWithValue("@id_Cliente", AgregarFactura.id_Cliente);
                    cmd.Parameters.AddWithValue("@id_DetallesFactura", AgregarFactura.id_DetallesFactura);
                    cmd.Parameters.AddWithValue("@id_Municipio", AgregarFactura.id_Municipio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarFactura()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarFactura", conex))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void ActualizarFactura(Ce_Factura ActualizarFactura)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ActualizarFactura", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ActualizarFactura.id);
                    cmd.Parameters.AddWithValue("@FchExpedicion", ActualizarFactura.FchExpedicion);
                    cmd.Parameters.AddWithValue("@id_Cliente", ActualizarFactura.id_Cliente);
                    cmd.Parameters.AddWithValue("@id_DetallesFactura", ActualizarFactura.id_DetallesFactura);
                    cmd.Parameters.AddWithValue("@id_Municipio", ActualizarFactura.id_Municipio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarFactura(Ce_Factura EliminarFactura)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_EliminarFactura", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", EliminarFactura.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}