using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //a.Heredara de vehículo.Todos sus atributos serán privados.
    //b.manoDeObra, será de la clase y su valor se inicializará en su constructor(de clase),
    //  siendo el valor inicial: 932.99D.

    //c.Por defecto a un Automóvil se le reparara las ruedas.

    //d.CalcularCostoDeReparacion, calculara el costoDeReparacion y
    //  retornara true solo si el vehículo ya fue reparado (estadoDeReparacion).
    //  El costoDeReparacion se deducirá de sumar la manoDeObra y el valor de elementoAReparar.
    //e.La propiedad TicketDeReparacion retornara un string.
    //  Si no se pudo CalcularCostoDeReparacion, devolverá: $"Automovil aun en taller".
    //  De lo contrario devolverá: $"Ticket Nro {utilizar GetHashCode de la instancia}\nImporte: ${costoDeReparacion}".

    //f.MostrarDatos agregara elementoAReparar y el TicketDeReparacion.

    //g.La propiedad ElementoAReparar será de solo lectura.
    //h.La propiedad ManoDeObra en el Set solo permitirá cambiar el valor,
    //  solo si el nuevo importe es mayor al actual.

    //i.Sobre escribir ToString para exponer los datos del Automóvil.

    public class Automovil : Vehiculo
    {
        private EReparacion elementoAReparar;
        private static double manoDeObra;

        static Automovil()
        {
            Automovil.manoDeObra = 932.99D;
        }
        public Automovil(string patente, string marca) : base(patente, marca)
        {
            this.patente = patente;
            this.marca = marca;
            this.elementoAReparar = EReparacion.Ruedas;
        }
        public Automovil(string patente, string marca, EReparacion reparar) : this(patente, marca)
        {
            this.elementoAReparar = reparar;
        }

        public EReparacion ElementoAReparar
        {
            get
            {
                return this.elementoAReparar;
            }
        }
        public override string TicketDeReparacion
        {
            get
            {
                if (CalcularCostoDeReparacion())
                {
                    return $"Ticket Nro {this.GetHashCode()}\nImporte: ${base.costoDeReparacion}";
                }
                else
                {
                    return $"Automovil aun en taller";
                }
            }
        }

        public static double ManoDeObra
        {
            get
            {
                return Automovil.manoDeObra;
            }
            set
            {
                if (value > Automovil.manoDeObra)
                {
                    Automovil.manoDeObra = value;
                }
            }
        }

        protected override bool CalcularCostoDeReparacion()
        {
            if (base.estadoDeReparacion)
            {
                base.costoDeReparacion = manoDeObra + (double)elementoAReparar;
                return true;
            }
            return false;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Elemento a reparar: {this.elementoAReparar}");
            sb.AppendLine($"Ticket: {this.TicketDeReparacion}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
