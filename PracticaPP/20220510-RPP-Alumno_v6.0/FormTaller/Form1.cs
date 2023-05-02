using Entidades;

namespace FormTaller
{
    public partial class Form1 : Form
    {
        private Taller taller;
        public Form1()
        {
            InitializeComponent();
            taller = (string)"NUEVO TALLER";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbTipoVehiculo.DataSource = new List<String> { "Automovil", "Moto" };
            this.cmbReparacion.DataSource = Enum.GetValues(typeof(EReparacion));
            this.cmbTipoMoto.DataSource = Enum.GetValues(typeof(Moto.ETipo));
            this.cmbTipoMoto.Visible = false;
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoVehiculo.SelectedItem.ToString() == "Moto")
            {
                this.cmbTipoMoto.Visible = true;
                this.txtMarca.Visible = false;
                this.lblReparacion.Visible = false;
                this.cmbReparacion.Visible = false;
                this.cmbTipoMoto.Location = this.txtMarca.Location;
            }
            else
            {
                this.cmbTipoMoto.Visible = false;
                this.txtMarca.Visible = true;
                this.lblReparacion.Visible = true;
                this.cmbReparacion.Visible = true;
            }
        }

        private void ActualizarLista()
        {
            this.rchtListadoVehiculos.Text = Taller.MostrarVehiculosDelTaller(this.taller);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo;
            if (this.cmbTipoVehiculo.SelectedItem.ToString() == "Moto")
            {
                nuevoVehiculo = new Moto(this.txtPatente.Text,
               (Moto.ETipo)this.cmbTipoMoto.SelectedItem);
            }
            else
            {
                nuevoVehiculo = new Automovil(this.txtPatente.Text, txtMarca.Text,
               (EReparacion)this.cmbReparacion.SelectedItem);
            }
            this.taller += nuevoVehiculo;
            this.ActualizarLista();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoARetirar;
            if (this.cmbTipoVehiculo.SelectedItem.ToString() == "Moto")
            {
                vehiculoARetirar = new Moto(this.txtPatente.Text,
               (Moto.ETipo)this.cmbTipoMoto.SelectedItem);
            }
            else
            {
                vehiculoARetirar = new Automovil(this.txtPatente.Text,
               txtMarca.Text, (EReparacion)this.cmbReparacion.SelectedItem);
            }
            MessageBox.Show((this.taller - vehiculoARetirar), "Salida",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ActualizarLista();
        }
    }
}