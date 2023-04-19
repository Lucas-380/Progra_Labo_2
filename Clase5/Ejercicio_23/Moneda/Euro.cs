using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 0.9;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.cotizRespectoDolar);
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad == e2.GetCantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad == ((Euro)d).GetCantidad);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return (e.GetCantidad == ((Euro)p).GetCantidad);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
        }


    }
}
