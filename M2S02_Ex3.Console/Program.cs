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

    static void Main(string[] args)
    {
        Console.WriteLine("Opções da Calculadora");
        Console.WriteLine("-----------------------");
        for (int i = 0; i < 5; i++)
        {
           Console.WriteLine($"Opção {i} - {(opcoesCalculadora) i}");
        }
        Console.WriteLine("-----------------------");
        Console.Write("Escolha a opção: ");
        opcoesCalculadora opcaoEscolhida = (opcoesCalculadora) int.Parse(Console.ReadLine());

        Console.WriteLine($"Opção escolhida: {opcaoEscolhida}");
    }
}