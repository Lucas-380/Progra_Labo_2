using Moneda;

namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        private Euro e;
        private Dolar d;
        private Pesos p;
        public Form1()
        {
            InitializeComponent();

            textCotizacionEuro.Text = "0";
            textCotizacionPeso.Text = "0";
        }

        private bool ParsearDouble(TextBox textBox)
        {
            if (double.TryParse(textBox.Text, out double result))
            {
                textBox.Text = result.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Error - dato invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = "0";
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
        }

        private void BloquearText(TextBox textBox)
        {   
            textBox.Enabled = false;
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            if (!(this.textCotizacionEuro.Text == "0" || this.textCotizacionPeso.Text == "0") &&
                  this.btnCandado.ImageIndex == 1)
            {
                this.btnCandado.ImageIndex = 0;
                BloquearText(textCotizacionEuro);
                BloquearText(textCotizacionPeso);
            }
            else
            {
                this.btnCandado.ImageIndex = 1;
                this.textCotizacionEuro.Enabled = true;
                this.textCotizacionPeso.Enabled = true;
            }

        }
        private void textCotizacionEuro_Leave(object sender, EventArgs e)
        {
            if (ParsearDouble(textCotizacionEuro))
            {
                Euro.SetCotizacion(double.Parse(textCotizacionEuro.Text));
            }
        }

        private void textCotizacionPeso_Leave(object sender, EventArgs e)
        {
            if (ParsearDouble(textCotizacionPeso))
            {
                Pesos.SetCotizacion(double.Parse(textCotizacionPeso.Text));
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (this.btnCandado.ImageIndex == 0 && ParsearDouble(txtEuro))
            {
                Euro euros = new Euro(double.Parse(txtEuro.Text));
                Dolar dolares = (Dolar)euros;
                Pesos pesos = (Pesos)euros;

                this.txtEuroADolar.Text = dolares.GetCantidad().ToString();
                this.txtEuroAEuro.Text = txtEuro.Text;
                this.txtEuroAPeso.Text = pesos.GetCantidad().ToString();

                BloquearText(txtEuroADolar);
                BloquearText(txtEuroAEuro);
                BloquearText(txtEuroAPeso);
            }
            else
            {
                MessageBox.Show("Error - Asegurese de cargar bien los datos y bloquear la cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (this.btnCandado.ImageIndex == 0 && ParsearDouble(txtPeso))
            {
                Pesos pesos = new Pesos(double.Parse(txtPeso.Text));
                Dolar dolares = (Dolar)pesos;
                Euro euros = (Euro)pesos;

                this.txtPesoAEuro.Text = euros.GetCantidad().ToString();
                this.txtPesoADolar.Text = dolares.GetCantidad().ToString();
                this.txtPesoAPeso.Text = txtPeso.Text;

                BloquearText(txtPesoAEuro);
                BloquearText(txtPesoADolar);
                BloquearText(txtPesoAPeso);
            }
            else
            {
                MessageBox.Show("Error - Asegurese de cargar bien los datos y bloquear la cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (this.btnCandado.ImageIndex == 0 && ParsearDouble(txtDolar))
            {
                Dolar dolares = new Dolar(double.Parse(txtDolar.Text));
                Euro euros = (Euro)dolares;
                Pesos pesos = (Pesos)dolares;

                this.txtDolarAEuro.Text = euros.GetCantidad().ToString();
                this.txtDolarADolar.Text = txtDolar.Text;
                this.txtDolarAPeso.Text = pesos.GetCantidad().ToString();

                BloquearText(txtDolarAEuro);
                BloquearText(txtDolarADolar);
                BloquearText(txtDolarAPeso);
            }
            else
            {
                MessageBox.Show("Error - Asegurese de cargar bien los datos y bloquear la cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}