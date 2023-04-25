using Entidades;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ejercicio_I02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] auxCursos = new string[3];
            string auxGenero = "";
            string auxDireccion = "";
            int auxEdad = 0;
            string auxNombre = "";
            string auxPais = "";

            int cantidad = 0;
            foreach (Control item in this.grpGenero.Controls)
            {
                if (((RadioButton)item).Checked)
                {
                    auxGenero = ((RadioButton)item).Text;
                    break;
                }
                cantidad++;
            }
            if (cantidad == this.grpGenero.Controls.Count)
            {
                MessageBox.Show("Debe ingresar un genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (int.Parse(this.numericEdad.Text) > 0 && int.Parse(this.numericEdad.Text) < 150)
            {
                auxEdad = int.Parse((this.numericEdad).Text);
            }
            else
            {
                MessageBox.Show("Datos invalidos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Regex name_validation = new Regex(@"^[a-zA-Z]+$");
            if ((!(string.IsNullOrEmpty(this.txtNombre.Text)) || !(string.IsNullOrEmpty(this.txtDireccion.Text))) && name_validation.IsMatch(this.txtNombre.Text))
            {
                auxNombre = this.txtNombre.Text;
                auxDireccion = this.txtDireccion.Text;
            }
            else
            {
                MessageBox.Show("Datos invalidos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            auxPais = listBoxPaises.Text;

            int i = 0;
            foreach (Control control in grpCursos.Controls)
            {
                if (((CheckBox)control).Checked)
                {
                    auxCursos[i] = ((CheckBox)control).Text;
                    Array.Sort(auxCursos);
                    i++;
                }
            }
            if (auxNombre != "" && auxDireccion != "" && auxGenero != "" && auxPais != "" && auxCursos[0] != "" && auxEdad != 0)
            {
                Ingresante nuevoIngresante = new Ingresante(auxNombre, auxDireccion, auxGenero, auxPais, auxCursos, auxEdad);
                MessageBox.Show(nuevoIngresante.Mostrar());
            }
        }
    }
}