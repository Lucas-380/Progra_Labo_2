namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar() 
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }
        //Sobrecarga de operadores de comparacion
        //Comparo dolar con dolar
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad == d2.GetCantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        //Comparo dolar con euro
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.GetCantidad == ((Dolar)e).GetCantidad);
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        //Comparo Dolar con Pesos
        public static bool operator ==(Dolar d, Pesos p)
        {
            return (d.GetCantidad == ((Dolar)p).GetCantidad);
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        //Sobrecarga de operadores
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }
    }
}