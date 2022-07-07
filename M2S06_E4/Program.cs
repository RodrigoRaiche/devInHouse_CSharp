using M2S06_E4;
using M2S06_E4.Dominio;
using M2S06_E4.Enums;


var listaProdutos = new[]
 {
    new Produto("Café", 15.00d, 100),
    new Produto("Caixa de Leite", 7.00d, 50),
    new Produto("Wafer", 5.50d, 70),
    new Produto("Chocolate", 9.75d, 45),
    new Produto("Suco de uva", 8.65d, 300),
    new Produto("Coca-cola", 10.25d, 372)
};

OpcaoMenu opcao = OpcaoMenu.Inicial;
CarrinhoCompra carrinhoCompra = new CarrinhoCompra();

while (opcao != OpcaoMenu.Sair)
{
    try
    {
        opcao = Tela.EscolherOpcao();
        if (opcao != OpcaoMenu.Sair)
        {
            switch (opcao)
            {
                case OpcaoMenu.AdicionarProduto:
                    {
                        Produto produtoEscolhido = Tela.EscolherProduto(listaProdutos);

                        int quantidade = Tela.ObterQuantidade();

                        produtoEscolhido.Estoque -= quantidade;

                        Produto produtoReduzido = new Produto(produtoEscolhido.NomeProduto, produtoEscolhido.Valor);

                        ItemCompra itemcompra = new ItemCompra(produtoReduzido, quantidade, produtoEscolhido.Valor * quantidade);
                        carrinhoCompra.AdicionarItem(itemcompra);
                        break;
                    }
                case OpcaoMenu.ListarCarrinho:
                    {
                        carrinhoCompra.ListarCarrinho();
                        break;

                    }
                case OpcaoMenu.RemoverProduto:
                    {
                        Produto produtoEscolhido = Tela.EscolherProduto(listaProdutos);

                        produtoEscolhido.Estoque += carrinhoCompra.ObterQuantidade(produtoEscolhido);
                        carrinhoCompra.RemoverItem(produtoEscolhido);
                        break;

                    }

            }

        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exceção {e.GetType().Name}.Captura com a mensagem: {e.Message}");
        continue;
    }
    Console.WriteLine(Environment.NewLine);


}








