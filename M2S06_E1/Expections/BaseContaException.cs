namespace M2S06_E1.Expections
{
    public abstract class BaseContaException : Exception
    {

        public const string MensagemPadrao = "{0} - conta ({1})";
        public string NumeroConta { get; set; }

        public BaseContaException(string message, string numeroConta) : base(string.Format(MensagemPadrao, message, numeroConta))
        {
            this.NumeroConta = numeroConta;

        }

        public BaseContaException(string message, string numeroConta, Exception innerException) : base(string.Format(MensagemPadrao, message, numeroConta), innerException)
        {
            this.NumeroConta = numeroConta;
        }

    }
}