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

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
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
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }


        public string MostrarDatos()
        {
            return $"Nombre: {this.Nombre}\t" +
                   $"Dni: {this.Dni}\t" +
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