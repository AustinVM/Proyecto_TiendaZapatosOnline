namespace CapaEntidades
{
    public class Ce_Usuario
    {
        public int id { get; set; }
        public string NombreUsuario { get; set; }
        public string ContraseniaUsuario { get; set; }
        public int ID_rol { get; set; }
        public bool EstadoUsuario { get; set; }

        public Ce_Usuario()
        {
            id = 0;
            NombreUsuario = "";
            ContraseniaUsuario = "";
            ID_rol = 0;
            EstadoUsuario = true;
        }
    }
}