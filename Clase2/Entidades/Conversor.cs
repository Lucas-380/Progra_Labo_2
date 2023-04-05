using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string numeroBinario = string.Empty;
            int resultadoDivision = numero;
            int restoDivision;

            if(numero > -1) 
            {
                do
                {
                    restoDivision = resultadoDivision % 2;
                    resultadoDivision /= 2;

                    numeroBinario = restoDivision.ToString() + numeroBinario;

                } while (resultadoDivision > 0);
            }

            return numeroBinario;
        }


        public static int BinarioDecimal(string numeroBinario)
        {
            int numeroDecimal = 0;
            int cantidadChar = numeroBinario.Length;

            foreach (char caracter in numeroBinario)
            {
                cantidadChar--;

                if(caracter == '1')
                {
                    numeroDecimal += (int)Math.Pow(2, cantidadChar);
                }

            }

            return(numeroDecimal);

        }



    }
}
