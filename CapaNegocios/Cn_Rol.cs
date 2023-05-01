using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Rol
    {
        Cd_Rol oCd_rol = new Cd_Rol();
        DataTable tabla;

        public Cn_Rol()
        {
            tabla = new DataTable();
        }

        public void AniadirRol(Ce_Rol rol)
        {
            oCd_rol.AniadirRol(rol);
        }

        public DataTable ConsultarRol()
        {
            tabla = oCd_rol.ConsultarRol();
            return tabla;
        }
    }
}
