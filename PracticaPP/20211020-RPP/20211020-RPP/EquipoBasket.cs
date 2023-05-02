using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211020_RPP
{
    public class EquipoBasket : Equipo
    {
        public enum ELiga { NBA, Euroleague, ACB }
        private ELiga liga;

        public EquipoBasket(string nombre, ELiga liga) : base(nombre) 
        {
            this.liga = liga;
        }
        public EquipoBasket(string nombre) : this(nombre, ELiga.NBA) { }

        public override int GetDificultad()
        {
            switch (this.liga)
            {
                case ELiga.NBA:
                    return new Random().Next(8, 10);
                case ELiga.Euroleague:
                    return new Random().Next(5, 10);
                default:
                    return new Random().Next(1, 7);
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Basket - " + base.MostrarDatos());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
