namespace CapaPresentacion
{
    public partial class Frm_MenuPrincipal : Form
    {
        ComboBox comboBox1 = new ComboBox();
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice y el texto del elemento seleccionado actualmente
            int selectedIndex = comboBox1.SelectedIndex;
            String selectedText = comboBox1.Text;

            // Mostrar una ventana emergente con la selección actual
            MessageBox.Show("Ha seleccionado el índice " + selectedIndex + " con texto " + selectedText);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            // Mostrar un mensaje cuando se abra la lista desplegable
            MessageBox.Show("Se ha abierto la lista desplegable");
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {

            // Agregar un elemento a la lista de opciones
            comboBox1.Items.Add("Opción 1");

            // Eliminar todos los elementos de la lista de opciones
            comboBox1.Items.Clear();

            // Eliminar el elemento en el índice 2 de la lista de opciones
            comboBox1.Items.RemoveAt(2);

            // Buscar el elemento “Opción 2” en la lista de opciones
            int index = comboBox1.FindStringExact("Opción 2");

            // Especificar la propiedad de los objetos de datos que se mostrará en el Combo Box
            comboBox1.DisplayMember = "NombreCompleto";

            // Especificar la propiedad de los objetos de datos que se utilizará para el valor de los elementos del Combo Box
            comboBox1.ValueMember = "Id";

            // Establecer el índice del elemento seleccionado en el índice 3
            comboBox1.SelectedIndex = 3;

            // Obtener el índice del elemento seleccionado actualmente
            int selectedIndex = comboBox1.SelectedIndex;

            // Agregar varios elementos al Combo Box de manera eficiente
            comboBox1.BeginUpdate();
            for (int i = 0; i < 1000; i++)
            {
                comboBox1.Items.Add("Opción " + i);
            }
            comboBox1.EndUpdate();

            // Actualizar el contenido del Combo Box con la fuente de datos actual
            comboBox1.Refresh();


        }




    }
}
