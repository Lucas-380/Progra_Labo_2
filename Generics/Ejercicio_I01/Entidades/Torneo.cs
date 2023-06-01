using System.Text;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;

        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(T equipo, Torneo<T> torneo)
        {
            foreach (T item in torneo.equipos)
            {
                if(item == equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(T equipo, Torneo<T> torneo)
        {
            return !(equipo == torneo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if(equipo != torneo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.nombre}");
            sb.AppendLine($"Equipos:");
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random num = new Random();
            return $"{equipo1.nombre} {num.Next(0,6)} - {equipo2.nombre} {num.Next(0, 6)}";
        }

        public string JugarPartido(T equipo1, T equipo2)
        {
            if (equipo1 == this && equipo2 == this)
            {
                return CalcularPartido(equipo1, equipo2);
            }
            return "Alguno o ambos equipos no estan en el torneo";
        }

    }
}