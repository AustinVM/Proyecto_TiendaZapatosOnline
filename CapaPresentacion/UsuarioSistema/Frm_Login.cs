using CapaEntidades.UsuarioSistema;
using CapaNegocios.UsuarioSistema;

namespace CapaPresentacion
{
    public partial class Frm_Login : Form
    {
        private Cn_Usuario oCn_Usuario = new Cn_Usuario();
        private Ce_Usuario oCe_Usuario = new Ce_Usuario();
        private Cn_Rol oCn_Rol = new Cn_Rol();

        public Frm_Login()
        {
            InitializeComponent();
        }

        #region MisMetodos

        private void ListarRoles()
        {
            CmbRol.DataSource = oCn_Rol.ConsultarRol();
            CmbRol.ValueMember = "id";
            CmbRol.DisplayMember = "nombre";
        }

        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            oCe_Usuario.ID_rol = Convert.ToInt32(CmbRol.SelectedValue);
            oCe_Usuario.NombreUsuario = TxtUsuario.Text;
            oCe_Usuario.ContraseniaUsuario = TxtContrasenia.Text;

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
                            Frm_MenuPrincipal MenPrin = new Frm_MenuPrincipal();
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
