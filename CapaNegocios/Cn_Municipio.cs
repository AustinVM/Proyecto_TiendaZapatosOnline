using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Municipio
    {
        Cd_Municipio oCd_Municipio = new Cd_Municipio();

        public void AggMunicipio(Ce_Municipio AggMunicipio)
        {
            oCd_Municipio.ActMunicipio(AggMunicipio);
        }

        public DataTable ConsultarMunicipio(Ce_Municipio ConsultarMunicipio)
        {
            DataTable dt = oCd_Municipio.ConsultarMunicipio(ConsultarMunicipio);
            return dt;
        }

        public void ActMunicipio(Ce_Municipio ActMunicipio)
        {
            oCd_Municipio.ActMunicipio(ActMunicipio);
        }

        public void ElimMunicipio(Ce_Municipio ElimMunicipio)
        {
            oCd_Municipio.ElimMunicipio(ElimMunicipio);
        }
    }
}
