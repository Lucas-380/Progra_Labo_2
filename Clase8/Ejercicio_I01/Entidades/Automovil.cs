using System.Text;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }


        public string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Soy un Auto");
            sb.AppendLine("Marchas: " + this.cantidadMarchas.ToString());
            sb.AppendLine("Pasajeros: " + this.cantidadPasajeros.ToString());

            sb.AppendLine("Ruedas: " + base.cantidadRuedas.ToString());
            sb.AppendLine("Puertas: " + base.cantidadPuertas.ToString());
            sb.AppendLine("Color: " + base.color.ToString());
            sb.AppendLine("-------------------------------------------------------");

            return sb.ToString();
        }


    }
}