namespace M2S06_E3.Exceptions
{
    public class AlunoEscolhidoInvalidoException : BaseException
    {
        public AlunoEscolhidoInvalidoException(string valor) : base("Aluno escolhido inválido", valor)
        {

        }

    }
}