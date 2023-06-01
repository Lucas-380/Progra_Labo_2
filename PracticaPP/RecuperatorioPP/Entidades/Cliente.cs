using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Guarnicion;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private List<Comida> menu;

        private Cliente(int dni)
        {
            this.dni = dni;
            this.menu = new List<Comida>();
        }

        private double TotalAPagar
        {
            get
            {
                double costoTotal = 0;
                foreach (Comida c in this.menu)
                {
                    costoTotal += c.Costo;
                }
                return costoTotal;
            }
        }

        /// <summary>
        /// Este metodo buscara en la lista de la instancia de menu la comida pasada por parametros
        /// </summary>
        /// <param name="comida">Es el objeto el cual se buscara en la lista</param>
        /// <returns>Retornara la primer comida que encuentre en la lista, en caso de que no este en la lista, retornara null</returns>
        public Comida BuscarComida(Comida comida)
        {
            foreach (Comida c in this.menu)
            {
                if (c.Equals(comida))
                {
                    return c;
                }
            }
            return null;
        }

        public static string ImprimirTicket(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cliente: {cliente.dni}");
            sb.AppendLine($"Menu del cliente");
            foreach (Comida c in cliente.menu)
            {
                sb.AppendLine(c.Descripcion);
            }
            sb.AppendLine($"Total a pagar: ${cliente.TotalAPagar}");
            return sb.ToString();
        }


        public static Cliente operator +(Cliente cliente, Comida comida)
        {
            cliente.menu.Add(comida);
            return cliente;
        }

        public static bool operator ==(Cliente cliente, Comida comida)
        {
            return cliente.menu.Contains(comida);
        }
        public static bool operator !=(Cliente cliente, Comida comida)
        {
            return !(cliente == comida);
        }

        public static implicit operator Cliente(int dni)
        {
            return Cliente.GetCliente(dni);
        }

        public static Cliente GetCliente(int dni)
        {
            return new Cliente(dni);
        }

    }
}
