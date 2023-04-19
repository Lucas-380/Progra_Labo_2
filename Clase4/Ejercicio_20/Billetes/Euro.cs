using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
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

        //recibe euro y se castea por la conversion a dolar y despues a Pesos
        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        //Sobrecarga de operadores
        //Comparo Euro con Euro
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad == e2.GetCantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        //Comparo Euro con Dolar
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad == ((Euro)d).GetCantidad);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        //Comparo Euro con Pesos
        public static bool operator ==(Euro e, Pesos p)
        {
            return (e.GetCantidad == ((Euro)p).GetCantidad);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        //Sobrecarga de operadores
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
