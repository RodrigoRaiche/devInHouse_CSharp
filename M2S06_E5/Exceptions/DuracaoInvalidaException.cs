namespace M2S06_E5.Exceptions;

public class DuracaoInvalidaException : Exception
{
    private const string Mensagem = "A duração {0} do compromisso não pode ser maior que 4 horas.";

    public string Duracao { get; private set; }

    public DuracaoInvalidaException(string duracao) : base(
        string.Format(Mensagem, duracao)
    )
    {
        Duracao = duracao;
    }
}