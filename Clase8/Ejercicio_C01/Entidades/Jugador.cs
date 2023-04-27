namespace Entidades
{
    public class Jugador : Persona
    {

        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            base.dni = dni;
            base.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles += value;
            }
        }


        public string MostrarDatos()
        {
            return $"Nombre: {base.Nombre}\t" +
                   $"Dni: {base.Dni}\t" +
                   $"Paridos Jugados: {this.PartidosJugados}\t" +
                   $"Total de goles: {this.TotalGoles}\t" +
                   $"Promedio de goles: {this.PromedioGoles.ToString()}\t";
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