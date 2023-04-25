using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos,  int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dirección: " + this.direccion);
            sb.AppendLine("Edad: " + this.edad);
            sb.AppendLine("Género: " + this.genero);
            sb.AppendLine("País: " + this.pais);
            sb.AppendLine("Curso/s: ");
            for (int i = 0; i < this.cursos.Length; i++)
            {
                if (!string.IsNullOrEmpty(this.cursos[i]))
                {
                    sb.AppendLine(this.cursos[i]);
                }
            }

            return sb.ToString();
        }
    }
}