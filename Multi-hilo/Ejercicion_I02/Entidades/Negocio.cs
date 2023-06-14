using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            Negocio.realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            this.clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();

            hilos.AddRange(AbrirCajas());

            hilos.Add(Task.Run(GenerarClientes));
            hilos.Add(Task.Run(AsignarCajas));

            return hilos;
        }

        public List<Task> AbrirCajas() 
        {
            List<Task> hilos = new List<Task>();
            foreach (Caja caja in this.cajas)
            {
                hilos.Add(caja.IniciarAtencion());
            }
            return hilos;
        }

        public void GenerarClientes()
        {
            while (true)
            {
                clientes.Enqueue(realNameGenerator.Generate());
                Thread.Sleep(1000);
            }
        }

        public void AsignarCajas() 
        {
            while (true)
            {
                Caja caja = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                this.clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrEmpty(cliente))
                {
                    caja.AgregarCliente(cliente);
                }
            }
        }






    }
}
