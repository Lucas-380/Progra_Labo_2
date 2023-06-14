namespace Ejercicio_I01
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}