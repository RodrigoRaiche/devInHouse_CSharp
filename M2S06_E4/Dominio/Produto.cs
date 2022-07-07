namespace M2S06_E4.Dominio
{
    public class Produto
    {
        public string NomeProduto { get; private set; }
        public double Valor { get; private set; }
        public double Estoque { get; set; }

        public Produto(string nomeProduto, double valor, double estoque)
        {
            this.NomeProduto = nomeProduto;
            this.Valor = valor;
            this.Estoque = estoque;

        }

        public Produto(string nomeProduto, double valor)
        {
            this.NomeProduto = nomeProduto;
            this.Valor = valor;
        }

    }
}