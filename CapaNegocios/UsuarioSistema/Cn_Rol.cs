using CapaDatos.UsuarioSistema;
using CapaEntidades.UsuarioSistema;
using System.Data;

namespace CapaNegocios.UsuarioSistema
{
    public class Cn_Rol
    {
        Cd_Rol oCd_rol = new Cd_Rol();

        public void AgregarRol(Ce_Rol AgregarRol)
        {
            oCd_rol.AgregarRol(AgregarRol);
        }

        public DataTable ConsultarRol()
        {
            DataTable tabla = oCd_rol.ConsultarRol();
            return tabla;
        }

        public void ActualizarRol(Ce_Rol ActualizarRol)
        {
            oCd_rol.ActualizarRol(ActualizarRol);
        }

        public void EliminarRol(Ce_Rol EliminarRol)
        {
            oCd_rol.EliminarRol(EliminarRol);
        }
    }
}
