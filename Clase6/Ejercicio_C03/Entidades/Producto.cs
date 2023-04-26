namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private double precio;
        private int codigo;
        private static int ultimoCodigo;

        static Producto()
        {
            ultimoCodigo = 100;
        }

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.codigo = ultimoCodigo;
            ultimoCodigo++;
        }

        public string Nombre { get { return nombre; } }
        public double Precio { get { return precio; } }
        public int Codigo { get { return codigo; } }

    }
}