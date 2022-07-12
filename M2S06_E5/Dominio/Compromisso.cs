using M2S06_E5.Exceptions;

namespace M2S06_E5.Dominio;
public class Compromisso
{
    private const int HorasLimiteDuracao = 4;
    public DateOnly Dia { get; private set; }
    public TimeOnly Horario { get; private set; }
    public TimeSpan Duracao { get; private set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public Compromisso(DateOnly dia, TimeOnly horario, TimeSpan duracao, string nome, string descricao)
    {
        Dia = dia;
        Horario = horario;
        Nome = nome;
        Descricao = descricao;

        if (duracao > TimeSpan.FromHours(HorasLimiteDuracao))
        {
            throw new DuracaoInvalidaException(duracao.ToString());
        }

        Duracao = duracao;
    }
}