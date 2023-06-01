using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string? message, string clase, string metodo) : this(message, clase, metodo, null)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string? message, string clase, string metodo, Exception? innerException) : base(message, innerException){ }


        public override string ToString()
        {
            return $"Excepción en el método {this.nombreMetodo} de la clase {this.nombreClase}\t";
        }


    }
}
