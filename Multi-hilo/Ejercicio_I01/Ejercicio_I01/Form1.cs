namespace Ejercicio_I01
{
    public partial class Form1 : Form
    {
        Task tarea;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tarea = Task.Run(() => this.IniciarReloj());
        }

        public void AsignarHora(DateTime hora)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(() => this.AsignarHora(hora));
            }
            else
            {
                this.lblHora.Text = $"{hora}";
            }
        }

        private void IniciarReloj()
        {
            while (true)
            {
                this.AsignarHora(DateTime.Now);
                Thread.Sleep(1000);
            }
        }
    }
}