using Entidades;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno("Dure", "0001", "Lucas");
            Alumno alumnoDos = new Alumno("Martinez", "0002", "Juan");
            Alumno alumnoTres = new Alumno("Carlos", "0003", "Roberto");

            alumnoUno.setNotaPrimerParcial(7);
            alumnoUno.setNotaSegundoParcial(9);

            alumnoDos.setNotaPrimerParcial(6);
            alumnoDos.setNotaSegundoParcial(10);

            alumnoTres.setNotaPrimerParcial(3);
            alumnoTres.setNotaSegundoParcial(1);

            Console.WriteLine(Alumno.Mostrar(alumnoUno));
            Console.WriteLine(Alumno.Mostrar(alumnoDos));
            Console.WriteLine(Alumno.Mostrar(alumnoTres));

        }
    }
}