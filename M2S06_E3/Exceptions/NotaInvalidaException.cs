namespace M2S06_E3.Exceptions
{
    public class NotaInvalidaException : BaseException
    {
        public NotaInvalidaException(string valor) : base("Nota inválida", valor)
        {

        }

    }
}