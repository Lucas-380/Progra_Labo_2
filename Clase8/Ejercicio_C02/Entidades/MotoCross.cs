using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }
        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }


        public short Cilindrada
        {
            get 
            { 
                return this.cilindrada; 
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.cilindrada == a2.cilindrada;
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }

        public new string MostrarDatos()
        {
            return "SOY UNA MOTO F1 lelele";
        }


    }
}
