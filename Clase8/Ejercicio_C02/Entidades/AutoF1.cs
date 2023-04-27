using System.Text;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballoDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
        }
        public AutoF1(short numero, string escuderia, short caballoDeFuerza) : this(numero, escuderia)
        {
            this.caballoDeFuerza = caballoDeFuerza;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.caballoDeFuerza == a2.caballoDeFuerza;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public new string MostrarDatos()
        {
            return "SOY UN AUTO F1 lalal";
        }

    }
}