using CapaDatos.Conexion;
using CapaEntidades.Facturacion;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Cd_DetallesFactura
    {
        public void AgregarDetallesFactura(Ce_DetallesFactura AgregarDetallesFactura)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AgregarDetallesFactura", conex))
                {
                    cmd.Parameters.AddWithValue("@FchExpedicion", AgregarDetallesFactura.id);
                    cmd.Parameters.AddWithValue("@FchExpedicion", AgregarDetallesFactura.id_Producto_Talla);
                    cmd.Parameters.AddWithValue("@id_Cliente", AgregarDetallesFactura.id_TipoPago);
                    cmd.Parameters.AddWithValue("@id_DetallesDetallesFactura", AgregarDetallesFactura.id_Iva);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarDetallesFactura()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarDetallesFactura", conex))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void ActualizarDetallesFactura(Ce_DetallesFactura ActualizarDetallesFactura)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ActualizarDetallesFactura", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FchExpedicion", ActualizarDetallesFactura.id);
                    cmd.Parameters.AddWithValue("@FchExpedicion", ActualizarDetallesFactura.id_Producto_Talla);
                    cmd.Parameters.AddWithValue("@id_Cliente", ActualizarDetallesFactura.id_TipoPago);
                    cmd.Parameters.AddWithValue("@id_DetallesDetallesFactura", ActualizarDetallesFactura.id_Iva);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarDetallesFactura(Ce_DetallesFactura EliminarDetallesFactura)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_EliminarDetallesFactura", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", EliminarDetallesFactura.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}