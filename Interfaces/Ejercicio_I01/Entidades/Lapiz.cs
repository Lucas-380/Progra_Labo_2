using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;


        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color 
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        float IAcciones.UnidadesDeEscritura 
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            for (int i = texto.Length; i > 0 ; i--)
            {
                ((IAcciones)this).UnidadesDeEscritura -= 0.1f;
            }
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"=={this.GetType().Name}==");
            sb.AppendLine($"Tinta: {((IAcciones)this).UnidadesDeEscritura}");
            sb.AppendLine($"Color: {((IAcciones)this).Color}");

            return sb.ToString();
        }

    }
}
