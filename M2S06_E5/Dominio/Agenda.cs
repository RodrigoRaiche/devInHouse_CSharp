namespace M2S06_E5.Dominio;
public class Agenda
{

    public List<Compromisso> Compromissos { get; set; }
    public string Nome { get; set; }

    public Agenda(string nome)
    {
        this.Compromissos = new List<Compromisso> { };
        this.Nome = nome;
    }

    public void AdicionarCompromisso(Compromisso compromisso)
    {
        Compromissos.Add(compromisso);
    }

    public List<Compromisso> ObterCompromissosPorDia(DateOnly dataFiltragem)
    {
        return Compromissos
            .Where(c => c.Dia == dataFiltragem)
            .OrderBy(c => c.Horario)
            .ToList();
    }

    public List<Compromisso> ObterCompromissosHojeFuturos()
    {
        var dataHoraAtual = DateTime.Now;
        var dataAtual = DateOnly.FromDateTime(dataHoraAtual);
        var horaAtual = TimeOnly.FromDateTime(dataHoraAtual);

        return Compromissos
            .Where(c => c.Dia == dataAtual)
            .Where(c => c.Horario > horaAtual)
            .OrderBy(c => c.Horario)
            .ToList();
    }
}


