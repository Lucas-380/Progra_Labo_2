using C03_widowsForm.Properties;
using Entidades;
using System.Windows.Forms;

namespace C03_widowsForm
{
    public partial class MaquinaExpendedora : Form
    {
        Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
        Stack<Producto> papasFritas = new Stack<Producto>();
        Stack<Producto> cocaCola = new Stack<Producto>();
        Stack<Producto> alfajor = new Stack<Producto>();
        Stack<Producto> kitkat = new Stack<Producto>();
        Stack<Producto> milka = new Stack<Producto>();
        Stack<Producto> oreo = new Stack<Producto>();
        Stack<Producto> sevenUp = new Stack<Producto>();
        Stack<Producto> pepsi = new Stack<Producto>();
        Stack<Producto> agua = new Stack<Producto>();


        public MaquinaExpendedora()
        {
            InitializeComponent();
        }

        private void MaquinaExpendedora_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                papasFritas.Push(new Producto("Papas Fritas", 350));
                cocaCola.Push(new Producto("Coca Cola", 220));
                alfajor.Push(new Producto("Alfajor", 120));
                kitkat.Push(new Producto("Kit Kat", 100));
                milka.Push(new Producto("Milka", 130));
                oreo.Push(new Producto("Oreo", 270));
                sevenUp.Push(new Producto("7up", 220));
                pepsi.Push(new Producto("Pepsi", 220));
                agua.Push(new Producto("Agua", 100));
            }

            maquinaExpendedora.Add(1, papasFritas);
            maquinaExpendedora.Add(2, cocaCola);
            maquinaExpendedora.Add(3, alfajor);
            maquinaExpendedora.Add(4, kitkat);
            maquinaExpendedora.Add(5, milka);
            maquinaExpendedora.Add(6, oreo);
            maquinaExpendedora.Add(7, sevenUp);
            maquinaExpendedora.Add(8, pepsi);
            maquinaExpendedora.Add(9, agua);
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = "9";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Text = string.Empty;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int entradaUsuarioEntero = 0;
            if (int.TryParse(this.txtEntrada.Text, out entradaUsuarioEntero) && maquinaExpendedora.ContainsKey(entradaUsuarioEntero))
            {
                Producto productoElejido = maquinaExpendedora[entradaUsuarioEntero].Pop();
                this.txtSalida.Text = $"Elijio el producto {productoElejido.Nombre} - Valor: {productoElejido.Precio} - Codigo: {productoElejido.Codigo}";

                //verifico si quedan de ese tipo de prod en la maquina
                if (maquinaExpendedora[entradaUsuarioEntero].Count == 0)
                {
                    VerificarCantidadProductos(maquinaExpendedora);
                    maquinaExpendedora.Remove(entradaUsuarioEntero);
                }
            }
        }
        private void VerificarCantidadProductos(Dictionary<int, Stack<Producto>> dictionary)
        {
            foreach (KeyValuePair<int, Stack<Producto>> item in dictionary)
            {
                if (item.Value.Count == 0)
                {
                    switch (item.Key)
                    {
                        case 1:
                            this.imgPapasFritas.Image = null;
                            break;
                        case 2:
                            this.imgCoca.Image = null;
                            break;
                        case 3:
                            this.imgAlfajor.Image = null;
                            break;
                        case 4:
                            this.imgKitkat.Image = null;
                            break;
                        case 5:
                            this.imgMilka.Image = null;
                            break;
                        case 6:
                            this.imgOreo.Image = null;
                            break;
                        case 7:
                            this.imgSevenUp.Image = null;
                            break;
                        case 8:
                            this.imgPepsi.Image = null;
                            break;
                        case 9:
                            this.imgAgua.Image = null;
                            break;
                    }
                }
            }
        }
    }
}