namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            Random random = new Random();
            int[] numerosRandom = new int[20];

            for (int i = 0; i<numerosRandom.Length; i++)
            {
                numerosRandom[i] = random.Next(-100, 100);
            }
            Console.WriteLine("a. Mostrar array como fue ingresado");
            foreach (int i in numerosRandom)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("b. Mostrar positivos ordenados de forma decreciente");
            Array.Sort(numerosRandom);
            //Invierte los lugares
            Array.Reverse(numerosRandom);
            foreach (int i in numerosRandom)
            {
                if(i > 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("c. Mostrar negativos ordenados en forma creciente");
            Array.Sort(numerosRandom);
            foreach (int i in numerosRandom)
            {
                if (i < 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}