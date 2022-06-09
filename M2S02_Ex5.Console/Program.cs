class Calculadora
{
    public enum opcoesCalculadora
    {
        Sair,
        Adição,
        Subtração,
        Multiplicação,
        Divisão
    }

    public static void Main(string[] args)
    {
        opcoesCalculadora opcaoEscolhida = obterEscolha();
        float valor1 = 0;
        float valor2 = 0;
        float resultado = 0;

        while (opcaoEscolhida != opcoesCalculadora.Sair)
        {
            if (validarOpcao(opcaoEscolhida))
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Opção inválida");
                Console.WriteLine("-----------------------");
            }
            else
            {
                valor1 = obterValor(1);
                valor2 = obterValor(2);
                resultado = realizarCalculo(opcaoEscolhida, valor1, valor2);
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Operação: {valor1} {transformaOpcao(opcaoEscolhida)} {valor2} = {resultado}");
                Console.WriteLine("-----------------------");

            }

            opcaoEscolhida = obterEscolha();

        }
    }

    private static bool validarOpcao(opcoesCalculadora opcao)
    {
        if (opcao != opcoesCalculadora.Adição &&
            opcao != opcoesCalculadora.Subtração &&
            opcao != opcoesCalculadora.Multiplicação &&
            opcao != opcoesCalculadora.Divisão &&
            opcao != opcoesCalculadora.Sair)
        {
            return true;
        }
        return false;

    }

    private static opcoesCalculadora obterEscolha()
    {
        exibirOpcoesMenu();

        Console.Write("Escolha a opção: ");
        return (opcoesCalculadora)int.Parse(Console.ReadLine());
    }

    private static void exibirOpcoesMenu()
    {

        Console.WriteLine("Opções da Calculadora");
        Console.WriteLine("-----------------------");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Opção {i} - {(opcoesCalculadora)i}");
        }
        Console.WriteLine("-----------------------");
    }

    public static float obterValor(int valor)
    {
        Console.Write($"Digite o valor {valor}: ");
        return float.Parse(Console.ReadLine());
    }

    public static float realizarCalculo(opcoesCalculadora operacao, float valor1, float valor2)
    {
        float resultado = 0;
        switch (operacao)
        {
            case opcoesCalculadora.Adição:
                resultado = valor1 + valor2;
                break;
            case opcoesCalculadora.Subtração:
                resultado =  valor1 - valor2;
                break;
            case opcoesCalculadora.Multiplicação:
                resultado =  valor1 * valor2;
                break;
            case opcoesCalculadora.Divisão:
                resultado = valor1 / valor2;
                break;
        }

        return resultado;

    }

    public static char transformaOpcao(opcoesCalculadora operacao){
        char resultado = ' ';
        switch (operacao)
        {
            case opcoesCalculadora.Adição:
                resultado = '+';
                break;
            case opcoesCalculadora.Subtração:
                resultado = '-';
                break;
            case opcoesCalculadora.Multiplicação:
                resultado = '*';
                break;
            case opcoesCalculadora.Divisão:
                resultado = '/';
                break;
        }

        return resultado;

    }


}
