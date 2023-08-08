using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // a.Heredara de Vehículo.

    //b.Sus propiedades serán de solo lectura.Por defecto a las motos, solo le reparara el aceite.
    //c.Tendrá un enumerado ETipo. { Ciclomotor = 10, Scooter = 20,Sport = 30 }.
    //d.La marca en Moto será igual al tipo de Moto.
    //e.CalcularCostoDeReparacion, calculara el costoDeReparacion
    //  y retornara true solo si el vehículo ya fue reparado (estadoDeReparacion).
    //  El costoDeReparacion se deducirá del valor del ElementoAReparar.
    //  A este valor se incrementará porcentualmente en base al tipo de moto (+10% Ciclomotor, +20% Scooter y +30% Sport).
    //  Para recuperar el tipo de Moto utilizar el siguiente código:
    //i.Enum.Parse(typeof(ETipo),base.marca);
    //f.MostrarDatos agregara elementoAReparar y el TicketDeReparacion.
    //g.La propiedad TicketDeReparacion retornara un string. Si no se pudo CalcularCostoDeReparacion, devolverá:
    //  $"Moto aun en taller". De lo contrario devolverá: $"Ticket Nro {utilizar GetHashCode de la instancia}\nImporte: ${costoDeReparacion}".
    //h.Sobre escribir ToString para exponer los datos de Moto.

    public class Moto : Vehiculo
    {
        public enum ETipo { Ciclomotor = 10, Scooter = 20, Sport = 30 }

        public Moto(string patente, ETipo tipo) : base(patente, tipo.ToString()) { }

        public EReparacion ElementoAReparar
        {
            get
            {
                return EReparacion.Aceite;
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
                    return $"Moto aun en taller";
                }
            }
        }

        protected override bool CalcularCostoDeReparacion()
        {
            if (base.estadoDeReparacion)
            {
                base.costoDeReparacion = (double)ElementoAReparar + ((double)ElementoAReparar * (int)(Enum.Parse(typeof(ETipo), base.marca)) / 100);
                return true;
            }
            return false;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Elemento a reparar: {this.ElementoAReparar}");
            sb.AppendLine($"Ticket: {this.TicketDeReparacion}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }


    }
}