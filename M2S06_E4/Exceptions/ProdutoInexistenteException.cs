namespace M2S06_E4.Exceptions
{
    public class ProdutoInexistenteException : Exception
    {

        public ProdutoInexistenteException() : base("Produto não existe no carrinho para ser excluído")
        {

        }

    }
}