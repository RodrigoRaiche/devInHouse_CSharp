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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----------------------");
                Console.WriteLine("Opção inválida");
                Console.WriteLine("-----------------------");
                Console.ForegroundColor = ConsoleColor.White;

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
        Console.WriteLine("-----------------------");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Opção {i} - {(opcoesBancaria)i}");
        }
        Console.WriteLine("-----------------------");
        Console.ForegroundColor = ConsoleColor.White;
    }

}
