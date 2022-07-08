namespace M2S06_E4.Exceptions
{
    public class CarrinhoVazioException : Exception
    {


        public CarrinhoVazioException() : base("Não existe produto(s) no carrinho para visualização")
        {

        }


    }
}