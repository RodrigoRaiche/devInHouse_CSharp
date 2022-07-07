namespace M2S06_E4.Exceptions
{
    public class BaseException : Exception
    {

        public const string MensagemPadrao = "{0} - Valor ({1})";
        public string Valor { get; set; }

        public BaseException(string message) : base(message)
        {

        }

        public BaseException(string message, string valor) : base(string.Format(MensagemPadrao, message, valor))
        {
            this.Valor = valor;

        }

        public BaseException(string message, string valor, Exception innerException) : base(string.Format(MensagemPadrao, message, valor), innerException)
        {
            this.Valor = valor;
        }

    }
}