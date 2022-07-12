using M2S06_E5.Dominio;
using M2S06_E5.Enums;

OpcaoMenu opcao = OpcaoMenu.Inicial;
Agenda agenda = new Agenda("Agenda Audaces");

while (opcao != OpcaoMenu.Sair)
{
    try
    {
        opcao = Output.EscolherOpcao();
        if (opcao != OpcaoMenu.Sair)
        {
            switch (opcao)
            {
                case OpcaoMenu.CriarCompromisso:
                    {
                        string nomeCompromisso = Output.ObterNome();
                        string descricaoCompromisso = Output.ObterDescricao();

                        DateOnly diaEscolhido = Output.ObterDia();
                        TimeOnly horarioEscolhido = Output.ObterHora();
                        TimeSpan duracaoEscolhida = Output.ObterDuracao();
                        Compromisso compromisso = new Compromisso(diaEscolhido, horarioEscolhido, duracaoEscolhida, nomeCompromisso, descricaoCompromisso);

                        agenda.AdicionarCompromisso(compromisso);
                        break;
                    }
                case OpcaoMenu.CompromissoDia:
                    {
                        DateOnly diaEscolhido = Output.ObterDia();
                        List<Compromisso> compromissos = agenda.ObterCompromissosPorDia(diaEscolhido);
                        Output.ExibirCompromissos(compromissos);
                        break;

                    }
                case OpcaoMenu.ProximosCompromissos:
                    {
                        List<Compromisso> compromissos = agenda.ObterCompromissosHojeFuturos();
                        Output.ExibirCompromissos(compromissos);
                        break;

                    }

            }

        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exceção {e.GetType().Name}.Captura com a mensagem: {e.Message}");
        continue;
    }
    Console.WriteLine(Environment.NewLine);

}
