namespace M2S06_E1.Expections
{

    public class ContaNaoOperacionalException : BaseContaException
    {
        public ContaNaoOperacionalException(string numeroConta) : base("Conta não operacional", numeroConta)
        {
        }

    }
}