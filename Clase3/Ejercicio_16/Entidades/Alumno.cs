using System;
using System.Text;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Alumno()
        {
            Alumno.random = new Random();
        }
        public Alumno(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial > 3 && this.notaSegundoParcial > 3)
            {
                return random.Next(6, 10);
            }
            return -1;
        }
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public static string Mostrar(Alumno alumno)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido: {alumno.nombre} {alumno.apellido}");
            sb.AppendLine($"Legajo: {alumno.legajo}");
            sb.AppendLine($"Notas: {alumno.notaPrimerParcial} {alumno.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {alumno.CalcularPromedio()}");
            if (alumno.CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota final: {alumno.CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("ALUMNO DESAPROBADO");
            }
            return sb.ToString();
        }

        public void setNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void setNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
    }
}