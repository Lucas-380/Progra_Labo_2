using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        public enum ETipoCompetencia { F1, MotoCross };
        private ETipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, ETipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cantidad de competidores: " + this.cantidadCompetidores.ToString());
            sb.AppendLine("\tCantidad de vueltas: " + this.cantidadVueltas.ToString());
            if (this.competidores.Count > 0)
            {
                sb.AppendLine("--------------------------------------------------------------------------------------------------");
                sb.AppendLine("\nAUTOS F1 en competencia: ");
                foreach (VehiculoDeCarrera item in competidores)
                {
                    sb.AppendLine(item.MostrarDatos());
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            //if(c.tipo == Competencia.ETipoCompetencia.F1 && a.GetType() == typeof(AutoF1)) { }
            if((c.tipo == ETipoCompetencia.F1 && a is AutoF1) ||
               (c.tipo == ETipoCompetencia.MotoCross && a is MotoCross))
            {
                foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (item == a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            if ((c.tipo == ETipoCompetencia.F1 && a is AutoF1) ||
                (c.tipo == ETipoCompetencia.MotoCross && a is MotoCross))
            {
                return !(c == a);
            }
            return false;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            try
            {
                if (c.competidores.Count < c.cantidadCompetidores && c != a)
                {
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    Random random = new Random();
                    a.CantidadCombustible = (short)random.Next(15, 100);

                    return true;
                }      
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;


            /*

            return false;
            */
        }


        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c == a)
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
