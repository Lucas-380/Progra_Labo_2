using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211020_RPP
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;


        public EquipoFutbol(string nombre, bool jugadoresEstrellas) : base(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }
        public EquipoFutbol(string nombre) : this(nombre, false){ }


        public override int GetDificultad()
        {
            int random = new Random().Next(7, 10);
            if (jugadoresEstrellas)
            {
                return random * 2;
            }
            return random;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" Futbol - " + base.MostrarDatos());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
