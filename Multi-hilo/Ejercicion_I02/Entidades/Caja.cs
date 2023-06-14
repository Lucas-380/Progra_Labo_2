namespace Entidades
{
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string cadena);

        public static Random random;
        public Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;


        static Caja()
        {
            Caja.random = new Random();
        }
        public Caja(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido) 
        {
            this.clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        public string NombreCaja { get => nombreCaja; }
        public int CantidadDeClientesALaEspera { get => this.clientesALaEspera.Count; }

        internal void AgregarCliente(string cliente)
        {
            this.clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
        }

        private void AtenderClientes()
        {
            do
            {
                if (clientesALaEspera.Any())
                {
                    string cliente = this.clientesALaEspera.Dequeue();
                    this.delegadoClienteAtendido(this, cliente);
                    Thread.Sleep(Caja.random.Next(1000, 5000));
                }
            } while (true);
        }

    }
}