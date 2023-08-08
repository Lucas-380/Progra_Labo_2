using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
    a. Hereda de Vehículo.
    b. Tendrá un enumerado de ETipo con los ítems: {Ciclomotor, Scooter,Sport}
    c. Sus atributos tipo y valorHora, serán privados. valorHora será de clase y su
    valor se inicializará en el constructor de clase, siendo su valor 100.
    d. El Constructor de Instancia recibirá: La patente, hora de ingreso y el tipo de
    Moto.
    e. La propiedad ValorHora será de Clase y solo escritura, desde allí se podrá
    cambiar el valor de la hora para Moto, siempre que el valor recibido sea
    positivo.
    f. La propiedad CostoEstadia, retornara el cargo del estacionamiento para la
    Moto.
    g. El método CargoEstacionamiento, será protegido y retornará el cargo de la
    Moto, resultante de multiplicar las horas de la estadía por el valor de la hora.
    h. La propiedad Descripcion retornara el tipo de Moto.
    i. MostrarDatos será protegido, agregara información indicando que es una
    "****MOTO*****" y la descripción de este.
    j. ToString hará públicos los datos de Moto. 
    */
    public sealed class Moto : Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport }

        private ETipo tipo;
        private static double valorHora;

        static Moto()
        {
            Moto.valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipo) : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }

        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }


        public override string Descripcion
        {
            get { return this.tipo.ToString(); }
        }

        public override double CostoEstadia
        {
            get { return this.CargoDeEstacionamiento(); }
        }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("*******MOTO*******");
            sb.AppendLine(this.Descripcion.ToString());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
