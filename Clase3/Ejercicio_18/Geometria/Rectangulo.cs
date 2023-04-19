using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());

            this.area = Math.Abs((this.vertice1.GetX() - this.vertice3.GetX()) * (this.vertice1.GetY() - this.vertice3.GetY()));
            this.perimetro = Math.Abs((this.vertice1.GetX() - this.vertice3.GetX()) + (this.vertice1.GetY() - this.vertice3.GetY())) * 2;
        }

        public float GetArea()
        {
            return this.area;
        }
        public float GetPerimetro()
        {
            return this.perimetro;
        }

    }
}
