namespace M2S06_E1.Exceptions
{

    public class ValorMaiorLimiteException : BaseContaException
    {
        public ValorMaiorLimiteException(string numeroConta) : base("Saldo insuficiente", numeroConta)
        {
        }

    }
}