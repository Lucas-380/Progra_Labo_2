using Entidades;
using System.Drawing;


namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nombre de la mascota
            //Edad(Validar 1 - 12)
            //Tipo: (Validar “gato”, “perro”, “hamster”)
            //Peso: (Validar 0 - 50)
            //Diagnostico: (Validar  “otitis”, “alergias”, “parasitos”,)

            //Informes:

            //            Nombre de la mascota más vieja
            //Cantidad de mascotas con parásitos
            //Nombre, edad y diagnóstico de la mascota más joven ingresada.

            /*
            string nombreMascota;
            int edadMascota;
            string tipoMascota;
            int pesoMascota;
            string diagnostico;

            Console.WriteLine("Ingrese el nombre de la mascota");
            nombreMascota = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la mascota");
            int.TryParse(Console.ReadLine(), out edadMascota);

            while(edadMascota < 1 || edadMascota > 12)
            {
                Console.WriteLine("Error edad invalida (1-12)");
                Console.WriteLine("Ingrese la edad de la mascota");
                int.TryParse(Console.ReadLine(), out edadMascota);
            }

            Console.WriteLine("Ingrese el tipo de mascota");
            tipoMascota = Console.ReadLine();

            while(tipoMascota != "gato" && tipoMascota != "perro" && tipoMascota != "hamster")
            {
                Console.WriteLine("error. Ingrese el tipo de mascota");
                tipoMascota = Console.ReadLine();
            }


            Console.WriteLine("Ingrese el peso de la mascota");
            int.TryParse(Console.ReadLine(), out pesoMascota);

            while (pesoMascota < 0 || pesoMascota > 50)
            {
                Console.WriteLine("Error peso invalido (0-50)");
                Console.WriteLine("Ingrese el peso de la mascota");
                int.TryParse(Console.ReadLine(), out pesoMascota);
            }


            Console.WriteLine("Ingrese el diagnostico de mascota");
            diagnostico = Console.ReadLine();
            while (diagnostico != "otitis" && diagnostico != "alergia" && diagnostico != "parasitos")
            {
                Console.WriteLine("error. Ingrese el diagnostico de mascota");
                diagnostico = Console.ReadLine();
            }


            //Validador.ValidarNumero();

            Console.WriteLine(edadMascota);
            Console.WriteLine(diagnostico);
            Console.WriteLine(pesoMascota);
            Console.WriteLine(tipoMascota);
            */


            /*
            int numero;

            Console.WriteLine("Ingrese un numero entre -100 y 100");
            int.TryParse(Console.ReadLine(), out numero);

            while (Validador.Validar(numero, -100, 100))
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                int.TryParse(Console.ReadLine(), out numero);
            }

            Console.WriteLine($"El numero ingresado es {numero}");
            */


            //Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
            //cálculo del área que corresponda:
            //a. double CalcularCuadrado(double)
            //b. double CalcularTriangulo(double, double)
            //c. double CalcularCirculo(double)
            //El ingreso de los datos como la visualización se deberán realizar desde el método Main().


            //EJERCICIO 11
            /*
            int numero;
            int minimo = 0;
            int maximo = 0;
            int total = 0;
            int promedio;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese 10 numeros entre el -100 y el 100");
                    int.TryParse(Console.ReadLine(), out numero);
                } while (!Validacion.Validar(numero, -100, 100));

                if(numero < minimo)
                {
                    minimo = numero;
                }
                if(numero > maximo)
                {
                    maximo = numero;
                }

                total += numero;
            }
            promedio = total / 10;

            Console.WriteLine($"El numero minimo ingresado es: {minimo}");
            Console.WriteLine($"El numero maximo ingresado es: {maximo}");
            Console.WriteLine($"El promedio entre los 10 numeros es: {promedio}");
            */



            //EJERCICIO 12
            /*
            int numero;
            char respuesta;
            int total = 0;

            do
            {
                Console.WriteLine("Ingrese un numero para sumar.");
                int.TryParse(Console.ReadLine(), out numero);

                total += numero;

                Console.WriteLine("Desea ingresar otro numero? (Escriba 's' para sí o 'n' para no");
                respuesta = Console.ReadLine()[0];
            } while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.WriteLine($"La suma total de los numeros ingresados es: {total}");
            */


            //EJERCICIO 13
            /*
            Console.WriteLine(Conversor.DecimalBinario(155));
            Console.WriteLine(Conversor.BinarioDecimal("11001101"));
            */



            //EJERCICIO 14
            /*
            Console.WriteLine("Area de un CUADRADO de lado 5: " + CalculoDeArea.CalcularCuadrado(5));
            Console.WriteLine("Area de un TRIANGULO de base 5 y altura 10: " + CalculoDeArea.CalcularTriangulo(2,10));
            Console.WriteLine("Area de un CIRCULO de radio 5: " + CalculoDeArea.CalcularCirculo(5));
            */


            //EJERCICIO 15
            char respuesta;
            do
            {
                char operacion;
                int numeroUno;
                int numeroDos;
                int resultado;

                do
                {
                    Console.WriteLine("Ingrese el tipo de operacion que desea realizar (+,-,*,/)");
                    operacion = Console.ReadLine()[0];

                    Console.WriteLine("Ingrese el primer numero");
                    int.TryParse(Console.ReadLine(), out numeroUno);

                    Console.WriteLine("Ingrese el segundo numero");
                    int.TryParse(Console.ReadLine(), out numeroDos);


                } while (operacion != '+' && operacion != '-' && operacion != '/' && operacion != '*');

                resultado = Calculadora.Calcular(operacion, numeroUno, numeroDos);

                Console.WriteLine($"El resultado es: {resultado}");
                Console.WriteLine("Desea realizar otra operacion? (Escriba 's' para sí o 'n' para no");
                respuesta = Console.ReadLine()[0];
            } while (ValidarRespuesta.ValidaS_N(respuesta));


            Console.ReadKey();
        }
    }
}