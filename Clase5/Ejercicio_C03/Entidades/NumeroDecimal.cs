using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get { return this.numero; }
        }


        public string DecimalBinario(double numero)
        {
            string numeroBinario = string.Empty;
            int resultadoDivision = (int)numero;
            int restoDivision;

            if (numero > -1)
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

        //Conversiones implicitas
        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        //Explicita
        public static explicit operator NumeroBinario(NumeroDecimal numero)
        {
            return (NumeroBinario)numero.DecimalBinario(numero.Numero);
        }


        //Sobrecarga de operadores
        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero == ((NumeroDecimal)numeroBinario).Numero;
        }
        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }

        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario) 
        {
            return numeroDecimal.Numero + ((NumeroDecimal)numeroBinario).Numero;
        }
        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero - ((NumeroDecimal)numeroBinario).Numero;
        }

    }
}
