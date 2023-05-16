using CapaDatos.UsuarioSistema;
using CapaEntidades.UsuarioSistema;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace CapaNegocios.UsuarioSistema
{
    public class Cn_Usuario
    {
        private Cd_Usuario oCd_Usuario = new Cd_Usuario();

        public bool AgregarUsuario(Ce_Usuario AgregarUsuario)
        {
            switch (ConsultarUsuario(AgregarUsuario))
            {
                case true:
                    return false;
                case false:
                    AgregarUsuario.ContraseniaUsuario = EncriptarContrasenia(AgregarUsuario);
                    Cd_Usuario.AgregarUsuario(AgregarUsuario);
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
            ValidarUsuario.ContraseniaUsuario = EncriptarContrasenia(ValidarUsuario);

            var Consulta = from d in oCd_Usuario.ConsultarUsuario()
                           where d.NombreUsuario == ValidarUsuario.NombreUsuario && d.ContraseniaUsuario == ValidarUsuario.ContraseniaUsuario && d.Id_Rol == ValidarUsuario.Id_Rol
                           select d;

            if (Consulta.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ActualizarUsuario(Ce_Usuario ActualizarUsuario)
        {
            Cd_Usuario.ActualizarUsuario(ActualizarUsuario);
        }

        public void EliminarUsuario(Ce_Usuario EliminarUsuario)
        {
            Cd_Usuario.EliminarUsuario(EliminarUsuario);
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
