static class Program
{
    static void Main(string[] args)
    {
        Pessoa raiche = new Pessoa("Rodrigo Raiche", DateTime.Parse("16/04/1980 08:10"), 1.72, 90.01);
        raiche.visualizarDados();

        Console.WriteLine("Sua idade é:" + raiche.calcularIdade(raiche.DataNascimento));

    }
}