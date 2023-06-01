using Entidades;
using Entidades.Excepciones;

namespace Ejercicio_I02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtLitros.Text == "" || this.txtKilometros.Text == "")
                {
                    throw new ParametrosVaciosException("Alguno de los campos esta vacio");
                }
                this.rtbCalculador.Text = $"km / hs: {Calculador.Calcular(int.Parse(this.txtKilometros.Text), int.Parse(this.txtLitros.Text))}";
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato es incorrecto, ingrese solo numeros");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}