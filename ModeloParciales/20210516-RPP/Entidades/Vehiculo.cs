using static Entidades.Vehiculo;
using System.Text;
using System.Runtime.Intrinsics;

namespace Entidades
{
    /*
    a. Sera abstracta.
    b. Poseerá los atributos: patente, horaIngreso, horaEgreso. Todos Privados. El
    enumerado de la clase será público y tendrá los ítems {Automovil, Moto}.
    c. El Constructor de Vehículo recibirá la patente y la hora de ingreso. La
    asignación de Patente se realizará desde la propiedad.

    d. Las propiedades Descripcion y CostoEstadia en Vehículo, serán abstractas y de
    solo lectura.
    e. HoraEgreso, será de lectura y escritura. Se deberá validar que esta no sea
    inferior a la Hora de Ingreso.

    f. La propiedad Patente, será de lectura y escritura. La asignación se hará previa
    validación, considerando que:
    i. Posea una longitud entre 6 y 7 caracteres.
    g. ValidarPatente será privada.
    h. CargoEstacionamiento es protegido y en Vehículo retornara la cantidad de
    horas de la estadía del vehículo, obtenidos entre la hora de ingreso y egreso
    de este.
    i. MostrarDatos será protegido y expondrá la patente y la hora de ingreso del
    vehículo. Utilizar StringBuilder.
    j. Dos Vehiculos serán iguales si poseen la misma patente.
     */

    public abstract class Vehiculo
    {
        public enum EVehiculos { Automovil, Moto }

        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        protected Vehiculo(string patente, DateTime horaIngreso)
        { 
            this.horaIngreso = horaIngreso;
            this.patente = patente;
        }

        public abstract string Descripcion { get; }
        public abstract double CostoEstadia { get; }

        public DateTime HoraIngreso
        {
            get { return this.horaIngreso; }
        }
        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set 
            {
                if(value > this.HoraIngreso)
                {
                    this.horaEgreso = value; 
                }
            }
        }
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        private bool ValidarPatente(string patente)
        {
            if(patente.LongCount() > 5 && patente.LongCount() < 8) 
            {
                return true;
            }
            return false;
        }

        protected virtual double CargoDeEstacionamiento()
        {
            if(this.HoraIngreso.Hour == this.HoraEgreso.Hour)
            {
                return 1;
            }
            return (this.HoraEgreso - this.HoraIngreso).Hours;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente: " + this.Patente);
            sb.AppendLine("Hora de ingreso: " + this.HoraIngreso);
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object? obj)
        {
            return obj is Vehiculo && ((Vehiculo)obj) == this;
        }

    }
}