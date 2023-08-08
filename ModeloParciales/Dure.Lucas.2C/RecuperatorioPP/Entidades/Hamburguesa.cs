using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Comida;

namespace Entidades
{
    public class Hamburguesa : Comida
    {
        private static double costoBase;
        private bool esDoble;

        static Hamburguesa()
        {
            Hamburguesa.costoBase = 1500;
        }

        public Hamburguesa(string nombre) : this(nombre, false)
        {
        }

        public Hamburguesa(string nombre, bool esDoble) : base(nombre)
        {
            this.esDoble = esDoble;
        }


        protected override string AgregarIngredientes(EIngredientes ingrediente)
        {
            if(!(this.ingredientes.Contains(ingrediente)))
            {
                this.ingredientes.Add(ingrediente);
                return $"Se agrego {ingrediente} a su hamburguesa";
            }
            return $"No se pudo agregar {ingrediente} a su hamburguesa";
        }

        protected override double CalcularCosto()
        {
            double total = Hamburguesa.costoBase;
            if (this.esDoble)
            {
                total += 500;
            }
            foreach (EIngredientes ingrediente in this.ingredientes)
            {
                switch (ingrediente)
                {
                    case EIngredientes.QUESO:
                        total *= 1.1; 
                        break;
                    case EIngredientes.CEBOLLA:
                        total *= 1.08;
                        break;
                    case EIngredientes.LECHUGA:
                        total *= 1.07;
                        break;
                    case EIngredientes.TOMATE:
                        total *= 1.09;
                        break;
                    case EIngredientes.JAMON:
                        total *= 1.12;
                        break;
                    case EIngredientes.HUEVO:
                        total *= 1.13;
                        break;
                    case EIngredientes.PANCETA:
                        total *= 1.15;
                        break;
                }
            }

            return total;
        }

        public override string ToString()
        {
            string estado = "Simple";
            if (this.esDoble)
            {
                estado = "Doble";
            }
            return $"Hamburguesa - {estado}";
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
