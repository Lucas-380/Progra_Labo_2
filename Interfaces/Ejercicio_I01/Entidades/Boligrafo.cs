using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public ConsoleColor Color 
        {
            get 
            {
                return this.colorTinta;
            }
            set 
            {
                this.colorTinta = value;
            } 
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            for (int i = texto.Length; i > 0 ; i--)
            {
                this.UnidadesDeEscritura -= 0.3f;
            }
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            if(unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"=={this.GetType().Name}==");
            sb.AppendLine($"Tinta: {this.UnidadesDeEscritura}");
            sb.AppendLine($"Color: {this.Color}");

            return sb.ToString();
        }



    }
}
