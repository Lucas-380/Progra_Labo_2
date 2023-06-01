using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set
            {
                this.enCompetencia = value;
            }
        }
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Numero: {this.numero.ToString()}\t");
            sb.Append($"Escuderia: {this.escuderia}\t");
            sb.Append($"En Competencia: {this.enCompetencia}\t");
            sb.Append($"Vueltas restantes: {this.vueltasRestantes.ToString()}\t");
            sb.AppendLine($"Combustible: {this.cantidadCombustible.ToString()}\t");
            sb.AppendLine("--------------------------------------------------------------------------------------------------------");

            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }

        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }
    }
}
