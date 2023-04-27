using Entidades;

namespace Ejercicio_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "Los Berto");

            Jugador j1 = new Jugador(123, "Rigoberto", 5, 7);
            Jugador j2 = new Jugador(456, "Gilberto", 9, 10);
            Jugador j3 = new Jugador(789, "Roberto", 3, 1);
            Jugador j4 = new Jugador(999, "Alberto", 10, 6);
            Jugador j5 = new Jugador(123, "Umberto", 1, 1);

            DirectorTecnico dt1 = new DirectorTecnico("Lucas", new DateTime(2002, 10, 20));
            DirectorTecnico dt2 = new DirectorTecnico("carlo", new DateTime(2002, 10, 20));

            if (equipo + j1)
            {
                Console.WriteLine("Se agrego: " + j1.MostrarDatos());
            }

            if (equipo + j2)
            {
                Console.WriteLine("Se agrego: " + j2.MostrarDatos());
            }
            if (equipo + j3)
            {
                Console.WriteLine("Se agrego: " + j3.MostrarDatos());
            }


            if (equipo + j4)
            {
                Console.WriteLine("Se agrego: " + j4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("\nNO SE PUDO AGREGAR: " + j4.MostrarDatos());
            }


            if (equipo + j5)
            {
                Console.WriteLine("Se agrego: " + j5.MostrarDatos());
            }
            else
            {
                Console.WriteLine("\nNO SE PUDO AGREGAR: " + j5.MostrarDatos());
            }

            Console.WriteLine("\n======================Dt=========================");

            Console.WriteLine(dt1.MostrarDatos());
            Console.WriteLine(dt2.MostrarDatos());
            Console.WriteLine(dt1 == dt2);

            Console.WriteLine("================DATOS PERSONAS======================");
            Console.WriteLine(j1.Dni);
            Console.WriteLine(j1.Nombre);

        }
    }
}