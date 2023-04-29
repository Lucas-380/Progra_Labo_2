using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    internal abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probrar abstractos";
        }

        public abstract string MiPropiedad{ get; }

        public abstract string MiMetodo();



        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            return this.GetType() == obj.GetType();
        }
        public override int GetHashCode() 
        {
            return 1142510181;
        }

    }
}
