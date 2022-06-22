using System;
using M2S04_Ex10;
public static class Program
{
    public static void Main(string[] args)
    {
        Pessoa rodrigo = new Pessoa("Rodrigo", 25, 150.5, 1.72);
        var imc = rodrigo.calculaIMC();
        Console.WriteLine($"{rodrigo.Nome} sua categoria de IMC é {rodrigo.obterCategoriaIMC(imc)}");

        Pessoa mikaela = new Pessoa("Mikaela", 16, 40.5, 1.65);
        imc = mikaela.calculaIMC();
        Console.WriteLine($"{mikaela.Nome} sua categoria de IMC é {mikaela.obterCategoriaIMC(imc)}");

        Pessoa liliane = new Pessoa("Liliane", 23, 72.5, 1.72);
        imc = liliane.calculaIMC();
        Console.WriteLine($"{liliane.Nome} sua categoria de IMC é {liliane.obterCategoriaIMC(imc)}");

    }
}