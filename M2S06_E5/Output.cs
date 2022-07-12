using M2S06_E5.Enums;
using M2S06_E5.Exceptions;
using M2S06_E5.Dominio;

public static class Output
{

    public static OpcaoMenu EscolherOpcao()
    {
        Console.WriteLine("Escolha uma das opções: ");
        Console.WriteLine("1 - Criar compromisso");
        Console.WriteLine("2 - Mostrar compromisso - dia");
        Console.WriteLine("3 - Mostrar compromissos - futuros");
        Console.WriteLine("9 - Sair");

        var opcaoValida = OpcaoMenu.TryParse(Console.ReadLine(), out OpcaoMenu opcao);

        if (!opcaoValida)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("     opção inválida");
            Console.WriteLine("***************************");
            Console.WriteLine($"{Environment.NewLine}");
        }

        return opcao;
    }


    public static string ObterNome()
    {
        Console.Write("Informe o Nome do compromisso: ");
        string nomeCompromisso = Console.ReadLine();

        if (nomeCompromisso == "")
        {
            throw new NomeInvalidoException();
        }

        return nomeCompromisso;
    }

    public static string ObterDescricao()
    {
        Console.Write("Informe a Descrição do compromisso: ");
        string DescricaoCompromisso = Console.ReadLine();

        if (DescricaoCompromisso == "")
        {
            throw new DescricaoInvalidaException();
        }

        return DescricaoCompromisso;
    }

    public static DateOnly ObterDia()
    {
        Console.Write("Informe a Data do compromisso: ");
        try
        {
            var dataString = Console.ReadLine();

            var data = DateOnly.FromDateTime(DateTime.Parse(dataString));

            return data;

        }
        catch (Exception e)
        {
            throw new DataInvalidaException();
        }


    }

    public static TimeOnly ObterHora()
    {
        Console.Write("Informe o Horário do compromisso: ");
        try
        {
            var horarioString = Console.ReadLine();
            var horario = TimeOnly.FromDateTime(DateTime.Parse(horarioString));

            return horario;

        }
        catch (Exception e)
        {
            throw new HoraInvalidaException();
        }


    }

    public static TimeSpan ObterDuracao()
    {
        string duracaoString = "";
        Console.Write("Informe a Duração do compromisso: ");
        try
        {
            duracaoString = Console.ReadLine();

            return TimeSpan.Parse(duracaoString);

        }
        catch (Exception e)
        {
            throw new DuracaoInvalidaException(duracaoString);
        }


    }

    public static void ExibirCompromissos(List<Compromisso> compromissos)
    {
        if (compromissos.Count == 0)
        {
            Console.Write("Não existe compromissos para a data informada");
        }

        foreach (var compromisso in compromissos)
        {
            Console.WriteLine($"{compromisso.Nome} - {compromisso.Descricao} - {compromisso.Dia} - {compromisso.Horario} - ({compromisso.Duracao})");

        }

    }


}

