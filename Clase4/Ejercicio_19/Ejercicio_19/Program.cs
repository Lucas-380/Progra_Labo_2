namespace Ejercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador();
            long resultado = suma.Sumar(5,6);
            string cadena = suma.Sumar("Hola, ", "que tal?");
            int cantidadSuma = (int)suma;

            Sumador suma2 = new Sumador(1);
            long resultado2 = suma2.Sumar(5,4);
            int cantidadSuma2 = (int)suma2;

            Console.WriteLine(cantidadSuma); //2
            Console.WriteLine(resultado); // 11
            Console.WriteLine(cadena); // Hola, que tal?
            Console.WriteLine(resultado2); //9
            Console.WriteLine(cantidadSuma2); //2
            Console.WriteLine(suma + suma2); //4
            Console.WriteLine(suma | suma2); //true

        }
    }
}