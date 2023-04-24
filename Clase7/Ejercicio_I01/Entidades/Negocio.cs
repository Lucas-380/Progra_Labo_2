using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.CAJA_1);
        }
        public Negocio(string nombre) : this() 
        {
            this.nombre = nombre;
        }
        public Cliente? Cliente
        {
            get
            {
                if (this.clientes.Count > 0)
                {
                    return this.clientes.Dequeue();
                }
                return null;
            }
            set
            {
                if (!ClienteEnCola(value))
                {
                    clientes.Enqueue(value);
                }
            }
        }

        private bool ClienteEnCola(Cliente cliente)
        {
            return clientes.Contains(cliente);
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.ClienteEnCola(c);
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }

    }
}
