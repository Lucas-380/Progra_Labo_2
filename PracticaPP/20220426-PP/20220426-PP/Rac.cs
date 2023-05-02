using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220426_PP
{
    public class Rac : Empleado
    {
        public enum EGrupo { CALL_IN, CALL_OUT, RRSS }
        private EGrupo grupo = 0;
        private static double valorHora;

        static Rac()
        {
            Rac.valorHora = 875.90F;
        }
        public Rac(string legajo, string nombre, TimeSpan horaIngreso) : base(legajo, nombre, horaIngreso){ }
        public Rac(string legajo, string nombre, TimeSpan horaIngreso, EGrupo grupo) : this(legajo, nombre, horaIngreso)
        {
            this.grupo = grupo;
        }

        public EGrupo Grupo
        {
            get
            {
                return this.grupo;
            }
        }
        public static double ValorHora
        {
            get
            {
                return Rac.valorHora;
            }
            set
            {
                if (value > 0)
                {
                    Rac.valorHora = value;
                }
            }
        }

        public override string EmitirFactura()
        {
            return $"Factura de: {this.ToString()}\nImporte a facturar: {this.Facturar()}";
        }

        private double CalculaBonoDeGrupo()
        {
            switch (this.grupo)
            {
                case EGrupo.CALL_OUT:
                    return 0.1;

                case EGrupo.RRSS:
                    return 0.2;

                default:
                    return 0;
            }
        }

        protected override double Facturar()
        {
            return ((Rac.ValorHora * CalculaBonoDeGrupo()) + Rac.ValorHora) * base.Facturar();
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.grupo} - {base.legajo} - {base.nombre}";
        }

    }
}
