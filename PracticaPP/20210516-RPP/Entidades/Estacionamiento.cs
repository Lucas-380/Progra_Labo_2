using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
    a. Todos sus atributos serán privados.
    b. El atributo estacionamiento será de clase.
    c. El único constructor será privado y se encargará de inicializar la lista de
    vehículos, asignar un nombre al estacionamiento y definir su capacidad.
    d. GetEstacionamiento será de clase e implementará un patrón singleton para lo
    cual deberá:
    i. Si la variable estacionamiento es null, instanciar el objeto.
    ii. Si no es null, modificara la capacidad del estacionamiento.
    iii. En ambos casos, su última acción será retornar el objeto
    estacionamiento.
    e. La propiedad ListadoVehiculos será de solo lectura y retornará la lista de
    vehículos del estacionamiento.
    f. InformarSalida será de instancia, recibirá un Vehículo y retornará una cadena
    que informará:
    i. El nombre del Estacionamiento.
    ii. Los datos del vehículo.
    iii. La hora de salida.
    iv. El cargo del estacionamiento.
    g. Un Estacionamiento y un Vehículo serán iguales, si el Vehículo se encuentra en
    el estacionamiento.
    h. La sobrecargar del operador + (mas) permitirá agregar un Vehículo al
    Estacionamiento, siempre y cuando haya espacio disponible y el vehículo no se
    encuentre en él.
    i. La Sobrecarga del operador – (menos) permitirá retirar un Vehículo del
    estacionamiento, si es que este se encuentra en él. Antes de remover se
    deberá asignar una hora de Egreso al vehículo, usar DateTime.Now 
    */

    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento = null;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        private Estacionamiento(string nombre, int capacidad)
        {
            listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            Estacionamiento Instance = estacionamiento;
            if (null == Instance)
            {
                Instance = new Estacionamiento(nombre, capacidad);
                return Instance;
            }
            else
            {
                Instance.capacidadEstacionamiento = capacidad;
                return Instance;
            }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public List<Vehiculo> ListadoVehiculos
        {
            get { return this.listadoVehiculos; }
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"====={this.nombre}=====");
            sb.AppendLine(vehiculo.ToString());
            sb.AppendLine(vehiculo.HoraEgreso.ToString());

            sb.AppendLine(vehiculo.CostoEstadia.ToString());
            
            
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in estacionamiento.ListadoVehiculos)
            {
                if(v == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento.listadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                estacionamiento.listadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                estacionamiento.listadoVehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }




    }
}
