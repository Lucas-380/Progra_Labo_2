using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220426_PP
{
    public class CentroDeAtencion
    {
        private int cantRacsPorSuper;
        private List<Empleado> empleados;
        private string nombre;

        public CentroDeAtencion(string nombre, int cantRacsPorSuper)
        {
            this.cantRacsPorSuper = cantRacsPorSuper;
            this.nombre = nombre;
            this.empleados = new List<Empleado>();
        }

        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public static bool operator ==(CentroDeAtencion c, Empleado e)
        {
            foreach (Empleado emp in c.Empleados)
            {
                if (emp == e)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(CentroDeAtencion c, Empleado e)
        {
            return !(c == e);
        }


        private bool ValidaCantidadDeRacs()
        {
            int contadorRac = 0;
            foreach (Empleado emp in this.Empleados)
            {
                if (emp.GetType().Name == nameof(Rac))
                {
                    contadorRac++;
                }
            }

            if (contadorRac >= this.cantRacsPorSuper )
            {
                return true;
            }
            return false;
        }

        public static bool operator +(CentroDeAtencion c, Empleado e)
        {
            if (c != e)
            {
                if (e.GetType().Name == nameof(Supervisor) && c.ValidaCantidadDeRacs())
                {
                    c.Empleados.Add(e);
                    c.cantRacsPorSuper += c.cantRacsPorSuper;
                    return true;
                }
                else if (e.GetType().Name == nameof(Rac))
                {
                    c.Empleados.Add(e);
                    return true;
                }
            }
            return false;
        }

        public static string operator -(CentroDeAtencion c, Empleado e)
        {
            if (c == e)
            {
                e.HoraEgreso = DateTime.Now.TimeOfDay;
                c.Empleados.Remove(e);
                return e.EmitirFactura();
            }
            return "Empleado no encontrado";
        }

        public string ImprimirNomina()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Empleado emp in this.Empleados)
            {
                sb.AppendLine(emp.ToString());
            }
            return sb.ToString();
        }

    }
}
