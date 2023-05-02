using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
    a. Hereda de Vehículo.
    b. Sus atributos marca y valorHora, serán privados. valorHora será de clase y su
    valor se inicializará en el constructor de clase, siendo su valor 120.
    c. El Constructor de Instancia recibirá: La patente, hora de ingreso y la marca del
    Automovil.
    d. La propiedad ValorHora será de Clase y solo escritura, desde allí se podrá
    cambiar el valor de la hora para Automóvil, siempre que el valor recibido sea
    positivo.
    e. La propiedad CostoEstadia, retornara el cargo del estacionamiento para el
    Automóvil.
    f. El método CargoEstacionemiento, será protegido y retornará el cargo del
    Automóvil, resultante de multiplicar las horas de la estadía por el valor de la
    hora.
    g. La propiedad Descripcion retornara la marca del Automóvil.
    h. MostrarDatos será protegido, agregara información indicando que es un
    "****AUTOMOVIL*****" y la descripción de este.
    i. ToString hará públicos los datos de Automóvil.
    */
    public sealed class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        static Automovil()
        {
            Automovil.valorHora = 120;
        }

        public Automovil(string patente, DateTime horaIngreso, string marca) : base(patente, horaIngreso)
        {
            this.marca = marca;
        }

        public static double ValorHora
        {
            set 
            {
                if(value > 0)
                {
                    Automovil.valorHora = value;
                } 
            }
        }

        public override string Descripcion
        {
            get { return this.marca; }
        }

        public override double CostoEstadia
        {
            get { return this.CargoDeEstacionamiento(); }
        }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("****AUTOMOVIL*****");
            sb.AppendLine(this.Descripcion.ToString());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }



    }
}
