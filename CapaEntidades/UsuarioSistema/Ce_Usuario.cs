namespace CapaEntidades.UsuarioSistema
{
    public class Ce_Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string ContraseniaUsuario { get; set; }
        public int Id_Rol { get; set; }
        public bool EstadoUsuario { get; set; }

        public Ce_Usuario()
        {
            Id = 0;
            NombreUsuario = "";
            ContraseniaUsuario = "";
            Id_Rol = 0;
            EstadoUsuario = true;
        }

        public Ce_Usuario(string NombreUsuario, string ContraseniaUsuario, int Id_Rol)
        {
            Id = 0;
            this.NombreUsuario = NombreUsuario;
            this.ContraseniaUsuario = ContraseniaUsuario;
            this.Id_Rol = Id_Rol;
            EstadoUsuario = true;
        }

        public Ce_Usuario(string NombreUsuario, string ContraseniaUsuario, int Id_Rol, bool EstadoUsuario)
        {
            Id = 0;
            this.NombreUsuario = NombreUsuario;
            this.ContraseniaUsuario = ContraseniaUsuario;
            this.Id_Rol = Id_Rol;
            this.EstadoUsuario = EstadoUsuario;
        }
    }
}