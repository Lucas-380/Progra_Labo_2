using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //EJERCICIO 14
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularTriangulo(double baseDeTriangulo, double altura)
        {
            return (baseDeTriangulo * altura) / 2;
        }
        public static double CalcularCirculo(double radio)
        {
            return Math.Pow(radio, 2) * Math.PI;
        }

    }
}