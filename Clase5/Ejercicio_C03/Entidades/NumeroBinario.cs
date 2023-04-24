namespace Entidades
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero) 
        {
            this.numero = numero;
        }

        public string Numero
        {
            get { return this.numero; }
        }

        public double BinarioDecimal(string numeroBinario)
        {
            double numeroDecimal = 0;
            int cantidadChar = numeroBinario.Length;

            foreach (char caracter in numeroBinario)
            {
                cantidadChar--;
                if (caracter == '1')
                {
                    numeroDecimal += (int)Math.Pow(2, cantidadChar);
                }
            }
            return (numeroDecimal);
        }

        //Conversiones implicitas
        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario numero) 
        {
            //Retorna el numero decimal casteado con el metodo BinarioDecimal
            //NumeroDecimal crea un new NumeroDecimal
            return (NumeroDecimal)numero.BinarioDecimal(numero.Numero);
        }

        //Sobrecarga de operadores
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return b.Numero ==((NumeroBinario)d).Numero;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalBinario(((NumeroDecimal)numeroBinario).Numero + numeroDecimal.Numero);
        }
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalBinario(((NumeroDecimal)numeroBinario).Numero - numeroDecimal.Numero);
        }

    }
}