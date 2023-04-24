using Entidades;

namespace Ejercicio_C03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoBin.Enabled = false;
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
                MessageBox.Show("Error - Ingrese un numero donde corresponda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = "";
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
        }


        private bool VerificarBinario(TextBox textBox)
        {
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] != '0' && textBox.Text[i] != '1')
                {
                    MessageBox.Show("Error - Ingrese un numero BINARIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if (ParsearDouble(this.txtBinario) && VerificarBinario(this.txtBinario))
            {
                NumeroBinario numeroBinario = (NumeroBinario)txtBinario.Text;
                this.txtResultadoDec.Text = (((NumeroDecimal)numeroBinario).Numero).ToString();
            }
            else
            {
                this.txtResultadoDec.Clear();
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if (ParsearDouble(this.txtDecimal))
            {
                double.TryParse(txtDecimal.Text, out double result);
                NumeroDecimal numeroDecimal = (NumeroDecimal)result;

                this.txtResultadoBin.Text = (((NumeroBinario)numeroDecimal).Numero).ToString();
            }
            else
            {
                this.txtResultadoBin.Clear();
            }
        }
    }
}