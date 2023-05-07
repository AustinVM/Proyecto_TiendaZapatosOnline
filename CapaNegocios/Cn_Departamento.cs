using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Departamento
    {
        Cd_Departamento oCd_Departamento = new Cd_Departamento();

        public void AgregarDepartamento(Ce_Departamento AgregarDepartamento)
        {
            oCd_Departamento.AgregarDepartamento(AgregarDepartamento);
        }

        public DataTable ConsultarDepartamento()
        {
            DataTable dt = oCd_Departamento.ConsultarDepartamento();
            return dt;
        }

        public void ActualizarDepartamento(Ce_Departamento ActualizarDepartamento)
        {
            oCd_Departamento.ActualizarDepartamento(ActualizarDepartamento);
        }

        public void EliminarDepartamento(Ce_Departamento EliminarDepartamento)
        {
            oCd_Departamento.EliminarDepartamento(EliminarDepartamento);
        }
    }
}
