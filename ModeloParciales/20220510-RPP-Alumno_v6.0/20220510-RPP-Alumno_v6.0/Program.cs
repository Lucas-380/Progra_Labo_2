using Entidades;

namespace _20220510_RPP_Alumno_v6._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taller t = (string)"Los Hermanos";
            Automovil v = new Automovil("AAA", "Ford", EReparacion.Frenos);
            Automovil v2 = new Automovil("AAA", "Ford");
            Moto m = new Moto("BBB", Moto.ETipo.Sport);
            Moto m2 = new Moto("CCC", Moto.ETipo.Ciclomotor);
            Moto m3 = new Moto("AAA", Moto.ETipo.Scooter);
            Moto m4 = new Moto("DDD", Moto.ETipo.Scooter);
            t += v;
            t += v2;
            t += m;
            t += m2;
            t += m3;
            t += m;

            Console.WriteLine("======Vehiculos en taller=========");
            Console.WriteLine(Taller.MostrarVehiculosDelTaller(t));


            Console.WriteLine("======Retiro de vehiculos=========");
            Console.WriteLine(t - m4 + "\n");
            Console.WriteLine(t - v + "\n");
            Console.WriteLine(t - v2 + "\n");
            Console.WriteLine(t - m + "\n");

            Console.WriteLine("======Vehiculos aun en taller y reparados=========");
            Console.WriteLine(Taller.MostrarVehiculosDelTaller(t));

            Console.ReadKey();
        }
    }
}