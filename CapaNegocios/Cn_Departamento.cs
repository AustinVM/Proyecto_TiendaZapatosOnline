using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Departamento
    {
        Cd_Departamento oCd_Departamento = new Cd_Departamento();

        public void AggDepartamento(Ce_Departamento AggDepartamento)
        {
            oCd_Departamento.ActDepartamento(AggDepartamento);
        }

        public DataTable ConsultarDepartamento()
        {
            DataTable dt = oCd_Departamento.ConsultarDepartamento();
            return dt;
        }

        public void ActDepartamento(Ce_Departamento ActDepartamento)
        {
            oCd_Departamento.ActDepartamento(ActDepartamento);
        }

        public void ElimDepartamento(Ce_Departamento ElimDepartamento)
        {
            oCd_Departamento.ElimDepartamento(ElimDepartamento);
        }
    }
}
