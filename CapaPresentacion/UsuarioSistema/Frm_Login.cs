using CapaEntidades.UsuarioSistema;
using CapaNegocios.UsuarioSistema;
using CapaPresentacion.Global;

namespace CapaPresentacion
{
    public partial class Frm_Login : Form
    {
        private readonly Cn_Usuario oCn_Usuario = new();
        private readonly Cn_Rol oCn_Rol = new();

        public Frm_Login()
        {
            InitializeComponent();
        }

        #region MisMetodos

        private void ListarRoles()
        {
            CmbRol.DataSource = oCn_Rol.ConsultarRol();
            CmbRol.ValueMember = "Id";
            CmbRol.DisplayMember = "Nombre";
        }

        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Ce_Usuario oCe_Usuario = new(TxtUsuario.Text, TxtContrasenia.Text, Convert.ToInt32(CmbRol.SelectedValue));

            if (string.IsNullOrEmpty(TxtUsuario.Text) || string.IsNullOrEmpty(TxtContrasenia.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else
            {
                if (oCn_Usuario.ConsultarUsuario(oCe_Usuario) == false)
                {
                    MessageBox.Show("El usuario no existe.");
                }
                else
                {
                    switch (oCn_Usuario.ValidarUsuario(oCe_Usuario))
                    {
                        case true:
                            Cp_VarGlobal.NombreUsuario = TxtUsuario.Text;
                            Cp_VarGlobal.idRolUsuario = Convert.ToInt32(CmbRol.SelectedValue);
                            Frm_MenuPrincipal MenPrin = new();
                            MenPrin.Show();
                            this.Hide();
                            break;
                        case false:
                            MessageBox.Show("Datos incorrectos.");
                            break;
                    }
                }
            }
        }
    }
}
