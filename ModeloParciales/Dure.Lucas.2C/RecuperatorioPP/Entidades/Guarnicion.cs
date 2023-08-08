using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Comida;

namespace Entidades
{
    public class Guarnicion : Comida
    {
        public enum ETipo {  PAPAS_FRITAS = 1000, ENSALADA_RUSA = 750, ENSALADA_MIXTA = 500 }

        private ETipo tipo;

        public Guarnicion() : this(ETipo.PAPAS_FRITAS){ }

        public Guarnicion(ETipo tipo) : base(tipo.ToString())
        {
            this.tipo = tipo;
        }

        protected override string AgregarIngredientes(EIngredientes ingrediente)
        {
            if (!(this.ingredientes.Contains(ingrediente)) && this == ingrediente)
            {
                this.ingredientes.Add(ingrediente);
                return $"Se agrego {ingrediente} a su guarnicion";
            }
            return $"No se pudo agregar {ingrediente} a su guarnicion";
        }

        protected override double CalcularCosto()
        {
            double costo = (int)this.tipo;
            foreach (EIngredientes i in this.ingredientes)
            {
                switch (i)
                {
                    case EIngredientes.QUESO:
                        costo *= 1.1;
                        break;
                    case EIngredientes.PANCETA:
                        costo *= 1.15;
                        break;
                }
            }
            return costo;
        }

        public static explicit operator Guarnicion(ETipo tipo)
        {
            return new Guarnicion(tipo);
        }


        public static bool operator ==(Guarnicion g, EIngredientes ingredientes)
        {
            switch (ingredientes)
            {
                case EIngredientes.PANCETA:
                    return true;
                case EIngredientes.ADHERESO:
                    return true;
                case EIngredientes.QUESO:
                    return true;
                default:
                    return false;
            }
        }

        public static bool operator !=(Guarnicion g, EIngredientes ingredientes)
        {
            return !(g == ingredientes);
        }

        public override string ToString()
        {
            return $"Guarnicion de tipo {this.tipo}";
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ToString());
            return sb.ToString();
        }

    }
}
