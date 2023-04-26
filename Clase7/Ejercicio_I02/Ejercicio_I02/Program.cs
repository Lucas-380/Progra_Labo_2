namespace Ejercicio_I02
{
    using Entidades;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Pag. 1";
            libro[1] = "Pag. 2";
            libro[2] = "Pag. 3";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }

            libro[0] = "Pag. 0";
            libro[7] = "Final";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(libro[i]);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine(libro[0]);
            Console.WriteLine(libro[1]);
            Console.WriteLine(libro[2]);
            Console.WriteLine(libro[3]);
            Console.WriteLine(libro[4]);

        }
    }
}