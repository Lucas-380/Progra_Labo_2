using Ejercicio_I01;
using System.Text;

namespace FormPersona
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.lstPersonas.Items.Clear();

            List<Persona> personas = PersonaDAO.Leer();
            foreach (Persona persona in personas)
            {
                this.lstPersonas.Items.Add(persona);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text))
            {
                PersonaDAO.Guardar(new Persona(txtNombre.Text, txtApellido.Text));
                MessageBox.Show("Guardado exitosamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text))
            {
                PersonaDAO.Modificar(((Persona)(this.lstPersonas.SelectedItem)).Id, this.txtNombre.Text, this.txtApellido.Text);
                MessageBox.Show("Modificado exitosamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error - Campo de modificacion vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            this.txtNombre.Text = ((Persona)(this.lstPersonas.SelectedItem)).Nombre;
            this.txtApellido.Text = ((Persona)(this.lstPersonas.SelectedItem)).Apellido;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstPersonas.SelectedItem != null) 
            {
                PersonaDAO.Borrar(((Persona)(this.lstPersonas.SelectedItem)).Id);
                MessageBox.Show("Eliminado exitosamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error - Seleccione que persona desea borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}