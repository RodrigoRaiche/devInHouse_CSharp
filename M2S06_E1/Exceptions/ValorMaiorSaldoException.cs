namespace M2S06_E1.Exceptions
{

    public class ValorMaiorSaldoException : BaseContaException
    {
        public ValorMaiorSaldoException(string numeroConta) : base("Saldo insuficiente", numeroConta)
        {
        }

    }
}