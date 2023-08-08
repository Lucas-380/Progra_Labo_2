using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220426_PP
{
    public class Supervisor : Empleado
    {
        private static float valorHora;

        static Supervisor()
        {
            Supervisor.valorHora = 1025F;
        }

        public Supervisor(string legajo, string nombre, TimeSpan horaIngreso) : base(legajo, nombre, horaIngreso)
        { 
            
        }
        private Supervisor(string legajo) : this(legajo, "n/a", (new TimeSpan(09, 00, 00))){ }

        public static implicit operator Supervisor(string legajo)
        {
            return new Supervisor(legajo);
        }

        public static float ValorHora
        {
            get
            {
                return Supervisor.valorHora;
            }
            set
            {
                if(value > 0)
                {
                    Supervisor.valorHora = value;
                }
            }
        }



        public override string EmitirFactura()
        {
            return $"Factura de: {this.ToString()}\nImporte a facturar: {this.Facturar()}";
        }
        protected override double Facturar()
        {
            return base.Facturar() * Supervisor.valorHora ;
        }


        public override string ToString()
        {
            return $"{this.GetType().Name} - {base.legajo} - {base.nombre}";
        }






    }
}
