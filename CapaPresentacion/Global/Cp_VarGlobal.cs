namespace CapaPresentacion.Global
{
    public class Cp_VarGlobal
    {
        private string NombreUsuario { get; set; }
        private int idRolUsuario { get; set; }

        public Cp_VarGlobal(string NombreUsuario, int idRolUsuario)
        {
            this.NombreUsuario = NombreUsuario;
            this.idRolUsuario = idRolUsuario;
        }
    }
}
