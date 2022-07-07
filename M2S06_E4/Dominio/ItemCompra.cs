
namespace M2S06_E4.Dominio
{
    public class ItemCompra
    {
        public Produto Produto { get; private set; }

        public int Quantidade { get; private set; }

        public double ValorItem { get; private set; }

        public ItemCompra(Produto produto, int quantidade, double valorItem)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.ValorItem = valorItem;

        }
    }
}