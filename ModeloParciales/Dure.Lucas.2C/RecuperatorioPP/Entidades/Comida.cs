using System.Text;

namespace Entidades
{
    public abstract class Comida
    {
        public enum EIngredientes{ ADHERESO, QUESO = 10, CEBOLLA = 8, LECHUGA = 7, TOMATE = 9, JAMON = 12, HUEVO = 13, PANCETA= 15};

        protected List<EIngredientes> ingredientes;
        private string nombre;

        protected Comida(string nombre) : this(nombre, new List<EIngredientes>()){ }

        protected Comida(string nombre, List<EIngredientes> ingredientes)
        {
            this.nombre = nombre;
            this.ingredientes = ingredientes;
        }

        public double Costo
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string Descripcion
        {
            get
            {
                return this.MostrarDatos();
            }
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


        protected abstract string AgregarIngredientes(EIngredientes ingrediente);

        protected abstract double CalcularCosto();

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Costo: {this.Costo}");
            sb.AppendLine($"Ingredientes: ");
            foreach (EIngredientes ingrediente in this.ingredientes)
            {
                sb.AppendLine(ingrediente.ToString());
            }

            return sb.ToString();
        }


        public static bool operator ==(Comida c, EIngredientes ingrediente)
        {
            if (c.ingredientes.Contains(ingrediente))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Comida c, EIngredientes ingrediente)
        {
            return !(c == ingrediente);
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj is Comida && ((Comida)obj).Nombre == this.Nombre;
        }

        public static string operator +(Comida c, EIngredientes ingrediente)
        {
            return c.AgregarIngredientes(ingrediente);
        }


    }
}