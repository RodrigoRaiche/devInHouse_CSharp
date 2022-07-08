namespace M2S06_E4.Exceptions
{
    public class QuantidadeMaiorEstoqueException : Exception
    {

        public const string MensagemPadrao = "Quantidade({0}) maior que o estoque({1})";
        public string QtdInformada { get; set; }
        public string QtdEstoque { get; set; }

        public QuantidadeMaiorEstoqueException(string quantidade, string estoque) : base(string.Format(MensagemPadrao, quantidade, estoque))
        {
            this.QtdInformada = quantidade;
            this.QtdEstoque = estoque;

        }

    }
}