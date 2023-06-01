using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Basket");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Futbol");

            EquipoBasquet e1 = new EquipoBasquet("e1", DateTime.Now);
            EquipoBasquet e2 = new EquipoBasquet("e2", DateTime.Now);
            EquipoBasquet e3 = new EquipoBasquet("e3", DateTime.Now);

            EquipoFutbol River = new EquipoFutbol("River Plate", DateTime.Now);
            EquipoFutbol Boca = new EquipoFutbol("Boca Juniors", DateTime.Now);
            EquipoFutbol Lanus = new EquipoFutbol("Lanus", DateTime.Now);


            _ = torneoBasquet + e1;
            _ = torneoBasquet + e2;
            _ = torneoBasquet + e3;

            _ = torneoFutbol + River;
            _ = torneoFutbol + Boca;
            _ = torneoFutbol + Lanus;


            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido(River, Boca));
            Console.WriteLine(torneoBasquet.JugarPartido(e1, e3));


        }
    }
}