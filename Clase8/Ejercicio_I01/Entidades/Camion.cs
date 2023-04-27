using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Soy un camion");
            sb.AppendLine("Marchas: " +this.cantidadMarchas.ToString());
            sb.AppendLine("Peso de carga: " + this.pesoCarga.ToString());

            sb.AppendLine("Ruedas: " + base.cantidadRuedas.ToString());
            sb.AppendLine("Puertas: " + base.cantidadPuertas.ToString());
            sb.AppendLine("Color: " + base.color.ToString());
            sb.AppendLine("-------------------------------------------------------");

            return sb.ToString();
        }


    }
}
