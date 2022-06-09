class CalculadoraAplicacaoBancaria
{
    public enum opcoesBancaria
    {
        Saldo,
        Depósito,
        Saque,
        Histórico,
        Sair
    }

    public static void Main(string[] args)
    {
        opcoesBancaria opcaoEscolhida = obterEscolha();
        float saldoConta = 0;

        while (opcaoEscolhida != opcoesBancaria.Sair)
        {
            if (validarOpcao(opcaoEscolhida))
            {
                exibeMensagem("Opção inválida");

            }
            else
            {
                switch (opcaoEscolhida)
                {
                    case opcoesBancaria.Saldo:
                        exibirSaldo(saldoConta);
                        break;
                    case opcoesBancaria.Depósito:
                        saldoConta = realizaDeposito(saldoConta);
                        break;
                    case opcoesBancaria.Saque:
                        break;
                    case opcoesBancaria.Histórico:
                        break;
                }

            }

            opcaoEscolhida = obterEscolha();

        }
    }

    private static bool validarOpcao(opcoesBancaria opcao)
    {
        if (opcao != opcoesBancaria.Saldo &&
            opcao != opcoesBancaria.Saque &&
            opcao != opcoesBancaria.Depósito &&
            opcao != opcoesBancaria.Histórico &&
            opcao != opcoesBancaria.Sair)
        {
            return true;
        }
        return false;

    }

    private static opcoesBancaria obterEscolha()
    {
        exibirOpcoesMenu();

        Console.Write("Escolha a opção: ");
        return (opcoesBancaria)int.Parse(Console.ReadLine());
    }

    private static void exibirOpcoesMenu()
    {
        Console.WriteLine("Opções da Aplicação Bancária");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("----------------------------------");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Opção {i} - {(opcoesBancaria)i}");
        }
        Console.WriteLine("----------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void exibirSaldo(float saldo)
    {
        Console.WriteLine("----------------------------------");
        if (saldo >= 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine($"O saldo da conta é R$: {saldo}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------------------------");

    }

    private static float realizaDeposito(float saldo)
    {
        float valorDeposito = 0;
        Console.Write("Digite o valor a ser depositado R$: ");
        valorDeposito = float.Parse(Console.ReadLine());

        if (valorDeposito <= 0)
        {
           exibeMensagem("Valor inválido");

        }
        else{
           saldo += valorDeposito;     
        }


        return saldo;

    }

    private static void exibeMensagem(string mensagem)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("----------------------------------");
        Console.WriteLine(mensagem);
        Console.WriteLine("----------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
    }

}
