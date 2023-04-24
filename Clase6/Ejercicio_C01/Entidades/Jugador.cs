namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private float promedioGoles;


        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
            return (float)this.totalGoles / this.partidosJugados;
        }

        public string MostrarDatos()
        {
            return $"Nombre: {nombre}\t" +
                   $"Dni: {dni}\t" +
                   $"Paridos Jugados: {partidosJugados}\t" +
                   $"Total de goles: {totalGoles}\t" +
                   $"Promedio de goles: {GetPromedioGoles().ToString()}\t";
        }

        public static bool operator ==(Jugador a, Jugador b)
        {
            return a.dni == b.dni;
        }
        public static bool operator !=(Jugador a, Jugador b)
        {
            return !(a == b);
        }






    }
}