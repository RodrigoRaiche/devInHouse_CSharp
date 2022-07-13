using M2S06_E4.Dominio;
using M2S06_E4.Exceptions;
using Xunit;

namespace M2S06_E9;

public class CarrinhoCompraTestes
{

    CarrinhoCompra carrinhoCompra = new CarrinhoCompra();
    private Produto CriarProduto()
    {
        return new Produto("Café", 15.00d, 100);
    }

    [Fact]
    public void Deveria_Cadastrar_Item_Carrinho_Compras()
    {
        // Preparação
        var produto = CriarProduto();
        int quantidade = 10;

        // Execução
        ItemCompra itemcompra = new ItemCompra(produto, quantidade, produto.Valor * quantidade);
        carrinhoCompra.AdicionarItem(itemcompra);

        // Validação do resultado
        Assert.NotNull(itemcompra);
        Assert.True(carrinhoCompra.ListaCompra.Count() > 0);
    }

    [Fact]
    public void Deveria_Somar_Total_Compra()
    {
        const double ValorEsperado = 150d;
        // Preparação
        var produto = CriarProduto();
        int quantidade = 10;

        // Execução
        ItemCompra itemcompra = new ItemCompra(produto, quantidade, produto.Valor * quantidade);
        carrinhoCompra.AdicionarItem(itemcompra);

        // Validação do resultado
        Assert.Equal(carrinhoCompra.TotalCompra, ValorEsperado);


    }

    [Fact]
    public void Deveria_Retirar_Produto_Carrinho()
    {
        const double ValorEsperado = 0d;
        // Preparação
        var produto = CriarProduto();
        int quantidade = 10;

        // Execução
        ItemCompra itemcompra = new ItemCompra(produto, quantidade, produto.Valor * quantidade);
        carrinhoCompra.AdicionarItem(itemcompra);
        carrinhoCompra.RemoverItem(produto);

        // Validação do resultado
        Assert.True(carrinhoCompra.ListaCompra.Count() == 0);
        Assert.Equal(carrinhoCompra.TotalCompra, ValorEsperado);



    }


}