using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Municipio
    {
        Cd_Municipio oCd_Municipio = new Cd_Municipio();

        public void AgregarMunicipio(Ce_Municipio AgregarMunicipio)
        {
            oCd_Municipio.AgregarMunicipio(AgregarMunicipio);
        }

        public DataTable ConsultarMunicipio(Ce_Municipio ConsultarMunicipio)
        {
            DataTable dt = oCd_Municipio.ConsultarMunicipio(ConsultarMunicipio);
            return dt;
        }

        public void ActualizarMunicipio(Ce_Municipio ActualizarMunicipio)
        {
            oCd_Municipio.ActualizarMunicipio(ActualizarMunicipio);
        }

        public void EliminarMunicipio(Ce_Municipio EliminarMunicipio)
        {
            oCd_Municipio.EliminarMunicipio(EliminarMunicipio);
        }
    }
}
