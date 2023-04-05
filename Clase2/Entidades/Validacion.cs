namespace Entidades
{
    public class Validacion
    {
        public static void ValidarNumero(string mensaje, out int valor, int min, int max)
        {
            Console.WriteLine(mensaje);
            int.TryParse(Console.ReadLine(), out valor);
            while(valor <min ||  valor > max)
            {
                Console.WriteLine($"ERROR VALOR INVALIDO, INGRESE UN VALOR ENTRE {min}-{max}");
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out valor);
            }
        }
        public static bool Validar(int valor, int min, int max)
        {
            if(valor > min && valor < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}