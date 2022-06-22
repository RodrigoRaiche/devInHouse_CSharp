using M2S04_Ex8;
static class Program
{
    static void Main(string[] args)
    {
        bool a = false;

        Console.WriteLine($"A tradução da variavel (a) que possui valor {a} é {a.traduzBolean()}");

        a = true;

        Console.WriteLine($"A tradução da variavel (a) que possui valor {a} é {a.traduzBolean()}");

        int valor1 = 10;
        
        Console.WriteLine($"A mulplicação do valor {valor1} por {2} é : {valor1.multiplica(2)}");

    }
}
