using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cuadrado : Rectangulo
    {
        private int lado;
        public Cuadrado(int lado) : base(lado, lado){ }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado";
        }

    }
}
