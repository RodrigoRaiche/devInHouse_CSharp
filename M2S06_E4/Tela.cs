using M2S06_E4.Dominio;
using M2S06_E4.Enums;
using M2S06_E4.Exceptions;

namespace M2S06_E4
{
    public static class Tela
    {

        public static OpcaoMenu EscolherOpcao()
        {
            Console.WriteLine("Escolha uma das opções: ");
            Console.WriteLine("1 - Adicionar produtos");
            Console.WriteLine("2 - Listar Carrinho");
            Console.WriteLine("3 - Remover Produto");
            Console.WriteLine("9 - Sair");

            var opcaoValida = OpcaoMenu.TryParse(Console.ReadLine(), out OpcaoMenu opcao);

            if (!opcaoValida)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("     opção inválida");
                Console.WriteLine("***************************");
                Console.WriteLine($"{Environment.NewLine}");
            }

            return opcao;
        }

        public static Produto EscolherProduto(Produto[] listaProdutos)
        {

            Console.WriteLine("Escolha um produto");
            for (int i = 0; i < listaProdutos.Length; i++)
            {
                Console.WriteLine($"Produto {i + 1} -  {listaProdutos[i].NomeProduto} - R$ {listaProdutos[i].Valor} - QtdEstoque: {listaProdutos[i].Estoque}");
            }

            var opcaoValidaProduto = int.TryParse(Console.ReadLine(), out var opcaoProduto);

            if (!opcaoValidaProduto || opcaoProduto == 0 || opcaoProduto > listaProdutos.Length)
            {
                throw new ProdutoInvalidoException();
            }

            return listaProdutos[opcaoProduto - 1];


        }

        public static int ObterQuantidade()
        {

            Console.WriteLine("Informe a quantidade: ");
            var quantidadeValida = int.TryParse(Console.ReadLine(), out var quantidade);
            if (!quantidadeValida || quantidade <= 0)
            {
                throw new QuantidadeInvalidaException();
            }

            return quantidade;

        }


    }
}