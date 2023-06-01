namespace Entidades.Exceptions
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}