using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº 1";
            /*
            Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
            valor máximo, el valor mínimo y el promedio.
            */

            /*
            int numero;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            int total = 0;
            int promedio;
            string valorIngresado;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero mayor a cero");
                    valorIngresado = Console.ReadLine();
                    int.TryParse(valorIngresado, out numero);
                } while (numero == 0);

                if (i == 0 || numero > numeroMaximo)
                {
                    numeroMaximo = numero;
                }

                if (i == 0 || numero < numeroMinimo)
                {
                    numeroMinimo = numero;
                }

                total += numero;
            }

            promedio = total / 5;

            Console.WriteLine("El numero maximo es: {0} ", numeroMaximo);
            Console.WriteLine("El numero minimo es: {0} ", numeroMinimo);
            Console.WriteLine("El el promedio de los numeros son: {0} ", promedio);
            */

            //Ejercicio 2
            /*
            double resultadoCubo;
            double resultadoCuadrado;
            string valorIngresado;
            int numero;

            Console.WriteLine("Ingrese un numero mayor a cero");
            valorIngresado = Console.ReadLine();
            int.TryParse(valorIngresado, out numero);

            while(numero < 1)
            {
                Console.WriteLine("Error. Reingresar número");
                Console.WriteLine("Ingrese un numero mayor a cero");
                valorIngresado = Console.ReadLine();
                int.TryParse(valorIngresado, out numero);
            }

            resultadoCuadrado = Math.Pow(numero, 2);
            resultadoCubo = Math.Pow(numero, 3);

            Console.WriteLine("Cuadrado: {0}", resultadoCuadrado);
            Console.WriteLine("Cubo: {0}", resultadoCubo);
            */

            // Ejercicio 3

            int maximo;

            Console.WriteLine("Ingrese un número hasta el cual se calcularan todos los números primos: ");
            while (!int.TryParse(Console.ReadLine(), out maximo))
            {
                Console.WriteLine("Error. Ingrese un valor entero y numérico.");
            }

            bool esPrimo;

            for (int i = 2; i <= maximo; i++)
            {
                esPrimo = true;

                for (int divisor = 2; divisor < i; divisor++)
                {
                    if ((i % divisor) == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                    Console.WriteLine("El número {0} es un número primo menor a {1}", i, maximo);
            }

            Console.ReadKey();

        }
    }
}