using M2S06_E3.Dominio;
using M2S06_E3.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        var alunos = new[]
         {
            new Aluno(101, "Rodrigo Raiche"),
            new Aluno(201, "José Alfredo"),
            new Aluno(301, "Janaina Alves"),
            new Aluno(401, "Liliane Oliveira")
         };


        var disciplinas = new[]
        {
            new Disciplina("Cálculo número", 4),
            new Disciplina("Algoritmo I", 3),
            new Disciplina("Algoritmo II", 5)
        };

        int opcao = 0;

        while (opcao != 9)
        {
            var opcaoValida = obterOpcoesMenu(ref opcao);

            if (!opcaoValida || opcao != 1 && opcao != 2 && opcao != 3 && opcao != 9)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("     opção inválida");
                Console.WriteLine("***************************");
                Console.WriteLine($"{Environment.NewLine}");

                continue;
            }

            if (opcao != 9)
            {

                try
                {
                    switch (opcao)
                    {

                        case 1:
                            {
                                int opcaoAluno = 0;
                                var opcaoValidaAluno = escolherAluno(ref opcaoAluno, alunos);

                                if (!opcaoValidaAluno || opcaoAluno > alunos.Length + 1)
                                {
                                    throw new AlunoEscolhidoInvalidoException(opcaoAluno.ToString());
                                    continue;
                                }


                                int opcaoDisciplina = 0;
                                var opcaoValidaDisciplina = escolherDisciplina(ref opcaoDisciplina, disciplinas);


                                if (!opcaoValidaDisciplina || opcaoDisciplina > disciplinas.Length + 1)
                                {
                                    throw new DisciplinaEscolhidaInvalidaException(opcaoDisciplina.ToString());
                                    continue;
                                }

                                float[] notas = new float[disciplinas[opcaoDisciplina - 1].QtdAvaliacoes];

                                Console.WriteLine("Informe as notas: ");
                                for (int i = 0; i < disciplinas[opcaoDisciplina - 1].QtdAvaliacoes; i++)
                                {
                                    var notaValida = float.TryParse(Console.ReadLine(), out var notaDisciplina);
                                    if (!notaValida || notaDisciplina > 10 || notaDisciplina < 0)
                                    {
                                        throw new NotaInvalidaException(notaDisciplina.ToString());
                                        continue;
                                    }
                                    notas[i] = notaDisciplina;

                                }

                                BoletimPorDisciplina boletimPorDisciplina = new BoletimPorDisciplina(disciplinas[opcaoDisciplina - 1], notas);
                                alunos[opcaoAluno - 1].Boletim.Add(boletimPorDisciplina);
                                break;
                            }
                        case 2:
                            {
                                listarTodasNotas(alunos, disciplinas);
                                break;


                            }
                        case 3:
                            {
                                int opcaoAluno = 0;
                                var opcaoValidaAluno = escolherAluno(ref opcaoAluno, alunos);

                                if (!opcaoValidaAluno || opcaoAluno > alunos.Length + 1)
                                {
                                    throw new AlunoEscolhidoInvalidoException(opcaoAluno.ToString());
                                    continue;
                                }

                                if (alunos[opcaoAluno - 1].Boletim.Count == 0)
                                {
                                    throw new AlunoSemDisciplinaException();
                                    continue;
                                }

                                listarBoletim(alunos, disciplinas, opcaoAluno);
                                break;


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
        }
    }

    private static bool obterOpcoesMenu(ref int opcao)
    {
        Console.WriteLine("Escolha uma das opções: ");
        Console.WriteLine("1 - Lançar Notas");
        Console.WriteLine("2 - Listar Notas");
        Console.WriteLine("3 - Visualizar Boletim");
        Console.WriteLine("9 - Sair");

        return int.TryParse(Console.ReadLine(), out opcao);

    }

    private static bool escolherAluno(ref int opcaoAluno, Aluno[] alunos)
    {

        Console.WriteLine("Escolha um aluno");
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno {i + 1} - Chamada: {alunos[i].NumeroChamada} - {alunos[i].NomeAluno}");

        }

        return int.TryParse(Console.ReadLine(), out opcaoAluno);

    }

    private static bool escolherDisciplina(ref int opcaoDisciplina, Disciplina[] disciplinas)
    {

        Console.WriteLine("Escolha uma disciplina: ");
        for (int i = 0; i < disciplinas.Length; i++)
        {
            Console.WriteLine($"Disciplina {i + 1} - {disciplinas[i].NomeDisciplina} - {disciplinas[i].QtdAvaliacoes}");

        }

        return int.TryParse(Console.ReadLine(), out opcaoDisciplina);

    }

    private static void listarTodasNotas(Aluno[] alunos, Disciplina[] disciplinas)
    {

        for (int k = 0; k < alunos.Length; k++)
        {
            if (alunos[k].Boletim.Count != 0)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Nome: {alunos[k].NomeAluno}");

                for (int i = 0; i < alunos[k].Boletim.Count; i++)
                {
                    Console.WriteLine($"Disciplina: {alunos[k].Boletim[i].DisciplinaBoletim.NomeDisciplina}");
                    for (int j = 0; j < alunos[k].Boletim[i].DisciplinaBoletim.QtdAvaliacoes; j++)
                    {
                        Console.WriteLine($"Notas provas: {alunos[k].Boletim[i].Notas[j]}");
                    }
                    Console.WriteLine($"Média: {alunos[k].Boletim[i].MediaNotas} ");
                }

            }

        }

    }

    private static void listarBoletim(Aluno[] alunos, Disciplina[] disciplinas, int opcaoAluno)
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("---BOLETIM ---");
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Nome: {alunos[opcaoAluno - 1].NomeAluno}");

        for (int i = 0; i < alunos[opcaoAluno - 1].Boletim.Count; i++)
        {
            Console.WriteLine($"Disciplina: {alunos[opcaoAluno - 1].Boletim[i].DisciplinaBoletim.NomeDisciplina}");
            for (int j = 0; j < alunos[opcaoAluno - 1].Boletim[i].DisciplinaBoletim.QtdAvaliacoes; j++)
            {
                Console.WriteLine($"Notas provas: {alunos[opcaoAluno - 1].Boletim[i].Notas[j]}");
            }
            Console.WriteLine($"Média: {alunos[opcaoAluno - 1].Boletim[i].MediaNotas}");
        }

    }
}
