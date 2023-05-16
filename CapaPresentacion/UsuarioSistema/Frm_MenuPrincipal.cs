using CapaPresentacion.Global;

namespace CapaPresentacion
{
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
            Permisos();            
        }

        #region MisMetodos

        private void Permisos()
        {
            switch (Cp_VarGlobal.idRolUsuario) // "Permisos" de los usuarios
            {
                case 2: // Vendedor
                    PbxProductos.Visible = false;
                    break;
                case 3: // Auxiliar
                    PbxProductos.Visible = false;
                    break;
                case 4: // Bodega
                    PbxProductos.Visible = false;
                    break;
            }
        }

        #endregion
    }
}

