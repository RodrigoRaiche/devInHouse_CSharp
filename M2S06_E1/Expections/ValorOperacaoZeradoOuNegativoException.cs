namespace M2S06_E1.Expections
{

    public class ValorOperacaoZeradoOuNegativoException : BaseContaException
    {
        public ValorOperacaoZeradoOuNegativoException(string numeroConta) : base("Valor da operação zerada ou negativa", numeroConta)
        {
        }

    }
}