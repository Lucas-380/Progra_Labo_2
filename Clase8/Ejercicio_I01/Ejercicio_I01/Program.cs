using Entidades;


namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(4, 4, VehiculoTerrestre.Colores.Rojo, 5, 5);
            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.Negro, 10);
            Camion camion = new Camion(6, 2, VehiculoTerrestre.Colores.Azul, 8, 120);


            Console.WriteLine(auto.mostrarDatos());
            Console.WriteLine(moto.mostrarDatos());
            Console.WriteLine(camion.mostrarDatos());


        }
    }
}