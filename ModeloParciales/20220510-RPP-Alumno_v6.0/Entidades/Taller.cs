using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //a.No se podrá heredar de dicha clase.
    //b.Sus atributos y único constructor serán privados.
    //  Este último será el encargado de inicializar los atributos.

    //c.Sus propiedades de solo lectura.

    //d.Sobre cargar implicitamente String de modo tal que retorne una Instancia de Taller.
    //e.MostrarVehiculosDelTaller será de clase y retornará un string con los datos de todos los vehículos del taller.Utilizar StringBuilder.

    //f.Un Taller y un Vehículo serán iguales si el vehículo se encuentra en la lista del taller (comparar por patente).
    //g.La sobre carga del operador + permitirá agregar un vehículo a la lista del taller, solo si este aun no fue agregado.
    //h.La sobre carga del operador – retornara un string
    //  y será el encargado de retirar un vehículo de la lista.Este solo se podrá retirar si el vehículo
    //  se encuentra en el taller,
    //  de lo contrario se informara "Vehiculo no encontrado".
    //  Antes de retirarlo se deberá cambiar el estado de reparación del vehículo a reparado,
    //  el mensaje a retornar será el TicketDeReparacion del vehículo.

    public sealed class Taller
    {
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Taller(string nombre)
        {
            this.nombre = nombre;
            this.vehiculos = new List<Vehiculo>();
        }

        public string Nombre { get { return nombre; } }
        public List<Vehiculo> Vehiculos { get { return vehiculos; } }


        public static implicit operator Taller(string nombre)
        {
            return new Taller(nombre);
        }


        public static string MostrarVehiculosDelTaller(Taller taller)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Vehiculo vehiculo in taller.vehiculos)
            {
                sb.AppendLine(vehiculo.ToString());
            }
            return sb.ToString();
        }

        public static bool operator ==(Taller t, Vehiculo v)
        {

            foreach (Vehiculo vehiculo in t.vehiculos)
            {
                if (vehiculo.Equals(v))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Taller t, Vehiculo v)
        {
            return !(t == v);
        }

        public static Taller operator +(Taller t, Vehiculo v)
        {
            if (t != v)
            {
                t.vehiculos.Add(v);
            }
            return t;
        }
        public static string operator -(Taller t, Vehiculo v)
        {
            if (t == v)
            {
                Vehiculo.RepararVehiculo(v);
                t.vehiculos.Remove(v);
                return v.TicketDeReparacion;
            }
            return "Vehiculo no encontrado";
        }

    }
}
