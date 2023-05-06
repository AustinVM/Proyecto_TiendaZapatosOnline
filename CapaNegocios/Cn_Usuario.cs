using CapaDatos;
using CapaEntidades;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace CapaNegocios
{
    public class Cn_Usuario
    {
        private Cd_Usuario oCd_Usuario = new Cd_Usuario();

        public bool AniadirUsuario(Ce_Usuario AniadirUsuario)
        {
            switch (ConsultarUsuario(AniadirUsuario))
            {
                case true:
                    return false;
                case false:
                    AniadirUsuario.ContraseniaUsuario = EncriptarContrasenia(AniadirUsuario);
                    oCd_Usuario.AniadirUsuario(AniadirUsuario);
                    return true;
            }
        }

        public bool ConsultarUsuario(Ce_Usuario ConsultarUsuario)
        {
            var Consulta = from d in oCd_Usuario.ConsultarUsuario() where d.NombreUsuario == ConsultarUsuario.NombreUsuario select d;

            if (Consulta.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarUsuario(Ce_Usuario ValidarUsuario)
        {
            bool valUsuario = false;

            ValidarUsuario.ContraseniaUsuario = EncriptarContrasenia(ValidarUsuario);
            var Consulta = from d in oCd_Usuario.ConsultarUsuario() 
                           where (d.NombreUsuario == ValidarUsuario.NombreUsuario && d.ContraseniaUsuario == ValidarUsuario.ContraseniaUsuario && d.ID_rol == ValidarUsuario.ID_rol)
                           select d;

            if (Consulta.Any())
            {
                valUsuario = true;
            }

            return valUsuario;
        }

        public void ActualizarUsuario(Ce_Usuario ActualizarUsuario)
        {
            oCd_Usuario.ActualizarUsuario(ActualizarUsuario);
        }
        
        public void EliminarUsuario(Ce_Usuario EliminarUsuario)
        {
            oCd_Usuario.EliminarUsuario(EliminarUsuario);
        }

        private static string EncriptarContrasenia(Ce_Usuario oCe_Usuario)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(oCe_Usuario.ContraseniaUsuario));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
