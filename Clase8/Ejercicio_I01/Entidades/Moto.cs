using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        { 
            this.cilindrada = cilindrada;
        }
        public string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Soy una moto");
            sb.AppendLine("cilindrada" +this.cilindrada.ToString());

            sb.AppendLine("Ruedas: " + base.cantidadRuedas.ToString());
            sb.AppendLine("Puertas: " + base.cantidadPuertas.ToString());
            sb.AppendLine("Color: " + base.color.ToString());
            sb.AppendLine("-------------------------------------------------------");

            return sb.ToString();
        }


    }
}
