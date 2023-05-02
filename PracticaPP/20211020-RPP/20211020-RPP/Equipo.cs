using System.Text;

namespace _20211020_RPP
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public int PE
        {
            get
            {
                return this.partidosEmpatados;
            }
            set
            {
                this.partidosEmpatados = value;
            }
        }
        public int PG
        {
            get
            {
                return this.partidosGanados;
            }
            set
            {
                this.partidosGanados = value;
            }
        }
        public int PJ
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
        public int PP
        {
            get
            {
                return this.partidosPerdidos;
            }
            set
            {
                this.partidosPerdidos = value;
            }
        }
        public int Puntuacion
        {
            get
            {
                return this.puntuacion;
            }
            set
            {
                this.puntuacion = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Tipo == obj.GetType().Name;
        }

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.Nombre == equipoB.Nombre && equipoA.Equals(equipoB);
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }
        
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            return sb.ToString();
        }

        public abstract int GetDificultad();

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            if (equipoA.Equals(equipoB))
            {
                if(equipoA.GetDificultad() > equipoB.GetDificultad())
                {//gana equipo A
                    equipoA.PJ++;
                    equipoA.PG++;
                    equipoA.Puntuacion += 3;
                    equipoB.PJ++;
                    equipoB.PP++;
                }
                else if(equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.PJ++;
                    equipoB.PG++;
                    equipoB.Puntuacion += 3;
                    equipoA.PJ++;
                    equipoA.PP++;
                }
                else
                {
                    equipoA.PJ++;
                    equipoA.PE++;
                    equipoA.Puntuacion += 1;
                    equipoB.PJ++;
                    equipoB.PE++;
                    equipoB.Puntuacion += 1;

                }
                return true;
            }
            return false;
        }
    }
}