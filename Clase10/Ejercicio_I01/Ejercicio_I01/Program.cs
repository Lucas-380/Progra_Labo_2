using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase clase = new OtraClase();
                clase.MetodoInstancia();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                while(ex.InnerException != null) 
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}