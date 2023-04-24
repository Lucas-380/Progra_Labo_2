using System.Text;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cantidad de competidores: "+ this.cantidadCompetidores.ToString());
            sb.Append("\tCantidad de vueltas: "+ this.cantidadVueltas.ToString());
            if(this.competidores.Count > 0)
            {
                sb.AppendLine("\tAUTOS F1 en competencia: ");
                sb.AppendLine("--------------------------------------------------------------------------------------------------------");
                foreach (AutoF1 item in competidores)
                {
                    sb.AppendLine(item.MostrarDatos());
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if(item == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                Random random = new Random();
                a.CantidadCombustible = (short)random.Next(15, 100);

                return true;
            }
            return false;
        }


        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                return true;
            }
            return false;
        }



    }
}