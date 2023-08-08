using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20211020_RPP
{
    public class Competencia
    {
        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        private Competencia(string nombre) : this(nombre, 5) { }
        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.nombre = nombre;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public List<Equipo> Equipos
        {
            get
            {
                return this.equipos;
            }
        }
        public int CantidadDeCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
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
        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }

        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            foreach (Equipo e in torneo.Equipos)
            {
                if(e == equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if(torneo != equipo && torneo.CantidadDeCompetidores > torneo.Equipos.Count)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }

        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"===={torneo.Nombre}====");
            sb.AppendLine($"=Cantidad max de competidores: {torneo.CantidadDeCompetidores}=");
            sb.AppendLine("======================================");

            foreach (Equipo e in torneo.Equipos)
            {
                sb.AppendLine(e.ToString());
            }
            return sb.ToString();
        }


    }
}
