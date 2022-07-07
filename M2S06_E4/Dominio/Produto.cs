using M2S06_E4.Exceptions;

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

        public void ReduzirEstoque(int quantidade)
        {
            if (quantidade > this.Estoque)
            {
                throw new BaseException("Quantidade maior que o estoque", quantidade.ToString());
            }

            this.Estoque -= quantidade;
        }

        public void AdicionarEstoque(int quantidade)
        {
            this.Estoque += quantidade;
        }


    }
}