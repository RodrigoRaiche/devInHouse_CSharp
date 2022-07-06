namespace M2S06_E3.Exceptions
{
    public class DisciplinaEscolhidaInvalidaException : BaseException
    {
        public DisciplinaEscolhidaInvalidaException(string valor) : base("Disciplina escolhida inválida", valor)
        {

        }

    }
}