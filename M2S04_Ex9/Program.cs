using M2S04_Ex9;
static class Program
{
    static void Main(string[] args)
    {
        bool a = false;

        Console.WriteLine($"A tradução da variavel (a) que possui valor {a} é {a.traduzBolean()}");

        a = true;

        Console.WriteLine($"A tradução da variavel (a) que possui valor {a} é {a.traduzBolean()}");

        int valor1 = 10;
        
        Console.WriteLine($"A mulplicação do valor {valor1} por 2 é : {valor1.multiplica(2)}");

        int valor2 = 20;
        
        Console.WriteLine($"A mulplicação do valor {valor2} por 2.5 é : {valor2.multiplica(2.5)}");

        
        Console.WriteLine($"A mulplicação do valor {valor2} por 2.5 e 2 é : {valor2.multiplica(2.5,2)}");

        Console.WriteLine($"A mulplicação do valor {valor2} por 2.5, 2 e 3 é : {valor2.multiplica(2.5,2,3)}");


    }
}
