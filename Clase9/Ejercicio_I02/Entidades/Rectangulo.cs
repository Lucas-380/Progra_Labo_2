using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        protected int ladoA;
        protected int ladoB;

        public Rectangulo(int ladoA, int ladoB)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo";
        }

        public override double CalcularPerimetro()
        {
            return (this.ladoA + this.ladoB) * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.ladoA * this.ladoB;
        }
    }
}
