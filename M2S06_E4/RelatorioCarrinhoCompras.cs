using M2S06_E4.Dominio;
using M2S06_E4.Exceptions;

namespace M2S06_E4
{
    public static class RelatorioCarrinhoCompras
    {
        public static void ListarCarrinho(CarrinhoCompra carrinhoCompra)
        {

            if (carrinhoCompra.ListaCompra.Count == 0)
            {
                throw new CarrinhoVazioException();
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("LISTA DE COMPRAS");

            for (int i = 0; i < carrinhoCompra.ListaCompra.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {carrinhoCompra.ListaCompra[i].Quantidade} unidade(s) - {carrinhoCompra.ListaCompra[i].Produto.NomeProduto} (R$ {carrinhoCompra.ListaCompra[i].Produto.Valor})  = R$ {carrinhoCompra.ListaCompra[i].ValorItem}");
            }
            Console.WriteLine($"Total compra: {carrinhoCompra.TotalCompra} ");
            Console.WriteLine("-----------------------------------");

        }

    }
}