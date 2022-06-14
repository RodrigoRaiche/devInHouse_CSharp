static class Program
{
    static void Main(string[] args)
    {
        Calcular soma1 = new Calcular(1);
        Console.WriteLine("A soma dos número é: " + soma1.Resultado);

        Calcular soma2 = new Calcular(1,2);
        Console.WriteLine("A soma dos número é: " + soma2.Resultado);

        Calcular soma3 = new Calcular(1,3,4);
        Console.WriteLine("A soma dos número é: " + soma3.Resultado);

        Calcular soma4 = new Calcular(1,4,5,6);
        Console.WriteLine("A soma dos número é: " + soma4.Resultado);

    }
}