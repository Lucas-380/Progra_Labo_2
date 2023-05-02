namespace _20220426_PP
{
    public abstract class Empleado
    {
        protected TimeSpan horaEgreso;
        protected TimeSpan horaIngreso;
        protected string legajo;
        protected string nombre;

        protected Empleado(string legajo, string nombre, TimeSpan horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public TimeSpan HoraIngreso { get { return horaIngreso; } }
        public string Nombre { get { return nombre; } }
        public string Legajo { get { return legajo; } } 
        public TimeSpan HoraEgreso
        {
            get 
            { 
                return this.horaEgreso; 
            }
            set
            {
                this.horaEgreso = ValidarHoraEgreso(value);
            }
        }
        
        private TimeSpan ValidarHoraEgreso(TimeSpan horaEgreso) 
        {
            if(horaEgreso > this.HoraIngreso)
            {
                return horaEgreso;
            }
            return DateTime.Now.TimeOfDay;
        }

        protected virtual double Facturar()
        {
            return HoraEgreso.TotalHours - HoraIngreso.TotalHours;
        }

        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            return emp1.Legajo == emp2.Legajo;
        }
        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }

        public abstract string EmitirFactura();

    }
}