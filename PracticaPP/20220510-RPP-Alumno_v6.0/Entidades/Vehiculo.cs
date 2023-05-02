using System.Text;

namespace Entidades
{
    //a.Sera abstracta.Todos sus atributos, así como su constructor, serán protegidos.
    //b.El atributo estadoDeReparacion deberá inicializarse en false. costoDeReparacion en 0 (cero)
    //c.Sus propiedades serán de solo lectura.
    //d.La propiedad EstadoDeReparacion retornara un string. En caso de su estado ser
    //  false devolverá: “Reparacion Pendiente”, de lo contrario “Reparado”.
    //e.Sobre escribir la funcionalidad del Equals de manera tal que 2 vehículos
    //  sean iguales si su patente es igual.
    //f.MostrarDatos será protegido.Expondrá los datos de Patente,
    //  Marca y EstadoDeReparacion (Para este último, usar la propiedad). Utilizar StringBuilder.
    //g.RepararVehiculo será de clase, y cambiará el estado de reparación de un vehículo a reparado (true).

    public abstract class Vehiculo
    {
        protected double costoDeReparacion;
        protected bool estadoDeReparacion;
        protected string marca;
        protected string patente;

        protected Vehiculo(string patente, string marca)
        {
            this.costoDeReparacion = 0;
            this.estadoDeReparacion = false;
            this.marca = marca;
            this.patente = patente;
        }

        public string EstadoDeReparacion
        {
            get
            {
                if (this.estadoDeReparacion == false)
                {
                    return "Reparacion Pendiente";
                }
                else
                {
                    return "Reparado";
                }
            }
        }
        public virtual string TicketDeReparacion { get; }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Vehiculo && ((Vehiculo)obj).patente == this.patente;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine($"Patente: {this.patente}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.Append($"Estado de reparacion: {this.EstadoDeReparacion}");
            return sb.ToString();
        }
        public static void RepararVehiculo(Vehiculo vehiculo)
        {
            if (vehiculo.estadoDeReparacion == false)
            {
                vehiculo.estadoDeReparacion = true;
            }
        }

        protected abstract bool CalcularCostoDeReparacion();

    }
}