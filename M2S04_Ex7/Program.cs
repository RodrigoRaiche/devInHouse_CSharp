using M2S04_Ex7;
static class Program
{
    static void Main(string[] args)
    {
        bool a = false;

        Console.WriteLine($"A tradução da variavel (a) que possui valor {a} é {a.traduzBolean()}");

        a = true;

        Console.WriteLine($"A tradução da variavel (a) que possui valor {a} é {a.traduzBolean()}");
    }
}
