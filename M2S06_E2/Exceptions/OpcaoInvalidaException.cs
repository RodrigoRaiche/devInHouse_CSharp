namespace M2S06_E2.Exceptions
{
    public class OpcaoInvalidaException : BaseException
    {
        public OpcaoInvalidaException(string valor) : base("Opção inválida", valor)
        {

        }

    }
}