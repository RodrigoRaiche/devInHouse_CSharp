
using System.Linq;
using M2S06_E4.Exceptions;

namespace M2S06_E4.Dominio
{
    public class CarrinhoCompra
    {

        public List<ItemCompra> ListaCompra { get; private set; }

        public double TotalCompra { get; private set; }


        public CarrinhoCompra()
        {
            this.ListaCompra = new List<ItemCompra> { };
            this.TotalCompra = 0;

        }

        public void AdicionarItem(ItemCompra itemCompra)
        {
            this.ListaCompra.Add(itemCompra);
            this.TotalCompra += itemCompra.ValorItem;

        }

        public void RemoverItem(Produto produto)
        {
            if (this.ListaCompra.Count() == 0)
            {
                throw new ProdutoInexistenteException();
            }

            this.TotalCompra -= ObterValor(produto);
            this.ListaCompra.RemoveAll(x => x.Produto.NomeProduto == produto.NomeProduto);
        }

        public int ObterQuantidade(Produto produto)
        {
            var queryQtd = from item in this.ListaCompra
                           where item.Produto.NomeProduto == produto.NomeProduto
                           select item.Quantidade;

            return queryQtd.Sum();
        }

        private double ObterValor(Produto produto)
        {
            var queryQtd = from item in this.ListaCompra
                           where item.Produto.NomeProduto == produto.NomeProduto
                           select item.ValorItem;

            return queryQtd.Sum();
        }


    }
}