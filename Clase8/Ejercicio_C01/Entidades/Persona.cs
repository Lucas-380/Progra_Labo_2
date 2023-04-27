using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        protected long dni;
        protected string nombre;
        
        
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
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

        public long Dni
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
                   $"Dni: {this.Dni}\t";
        }
    }
}
