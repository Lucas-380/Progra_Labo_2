namespace Entidades.Excepciones
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string message) : base(message) { }

        public ParametrosVaciosException(string mensaje, Exception innerException) : base(mensaje, innerException) { }

    }
}