using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Pesos()
        {
            Pesos.cotizRespectoDolar = 398;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static implicit operator Pesos(double cantidad)
        {
            return new Pesos(cantidad);
        }
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.cotizRespectoDolar);
        }
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad == p2.GetCantidad;
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return (p.GetCantidad == ((Pesos)d).GetCantidad);
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return (p.GetCantidad == ((Pesos)e).GetCantidad);
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }


    }
}
