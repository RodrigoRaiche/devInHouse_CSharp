using M2S06_E1.Dominio;
internal class Program
{
    private static void Main(string[] args)
    {
        var contas = new[]
        {
            new Conta("1000-1", 2500, 1000, true),
            new Conta("2000-5", 3700, 5000, false),
            new Conta("3000-7", 15000, 700, true)
        };

        int opcao = 0;

        while (opcao != 9)
        {
            Console.WriteLine("Selecione a conta ou digite 9 para sair");

            for (var i = 0; i < contas.Length; i++)
            {
                var conta = contas.ElementAt(i);
                Console.WriteLine($"{i + 1} - Conta {conta.NumeroConta}");
            }

            var opcaoValida = int.TryParse(Console.ReadLine(), out opcao);

            if (!opcaoValida || (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 9))
            {
                Console.WriteLine("***************************");
                Console.WriteLine("     opção inválida");
                Console.WriteLine("***************************");
                Console.WriteLine($"{Environment.NewLine}");

                continue;
            }

            if (opcao != 9)
            {
                var contaSelecionada = contas.ElementAt(opcao - 1);

                Console.WriteLine($"{Environment.NewLine} Selecione a operação:");
                Console.WriteLine("1 - Consulta saldo");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Deposito");

                var operacaoValida = int.TryParse(Console.ReadLine(), out var operacaoSelecionada);

                if (!operacaoValida || (operacaoSelecionada > 3))
                {
                    Console.WriteLine("***************************");
                    Console.WriteLine("     operação inválida");
                    Console.WriteLine("***************************");
                    Console.WriteLine($"{Environment.NewLine}");

                    continue;
                }

                try
                {
                    switch (operacaoSelecionada)
                    {
                        case 1:
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Saldo: {contaSelecionada.ObterSaldo()}");
                            Console.WriteLine("***************************");
                            break;

                        case 2:
                            Console.WriteLine($"{Environment.NewLine} Digite o valor:");
                            var valorValido = double.TryParse(Console.ReadLine(), out var valorInformado);

                            if (!valorValido)
                            {
                                Console.WriteLine("***************************");
                                Console.WriteLine("     Valor inválido");
                                Console.WriteLine("***************************");
                                Console.WriteLine(Environment.NewLine);
                                continue;
                            }

                            contaSelecionada.Sacar(valorInformado);
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Novo saldo: {contaSelecionada.ObterSaldo()}");
                            Console.WriteLine("***************************");
                            break;

                        case 3:
                            Console.WriteLine($"{Environment.NewLine} Digite o valor:");
                            var valorValidoDeposito = double.TryParse(Console.ReadLine(), out var valorInformadoDeposito);

                            if (!valorValidoDeposito)
                            {
                                Console.WriteLine("***************************");
                                Console.WriteLine("     Valor inválido");
                                Console.WriteLine("***************************");
                                Console.WriteLine(Environment.NewLine);
                                continue;
                            }

                            contaSelecionada.Depositar(valorInformadoDeposito);
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Novo saldo: {contaSelecionada.ObterSaldo()}");
                            Console.WriteLine("***************************");
                            break;


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exceção {e.GetType().Name} captura com a mensagem {e.Message}");
                    continue;
                }
                Console.WriteLine(Environment.NewLine);

            }


        }



    }

}