using M2S05;

public static class Program
{
    public static void Main(string[] args)
    {

        Robo robo1 = new RoboBatalhaPesado("Eliot");
        Robo robo2 = new RoboBatalhaLeve("Geremias");
        robo1.Iniciar();
        robo2.Iniciar();
        PartidaBatalha.Batalhar(robo1, robo2, 5);
        string resultado = Resultado.DecideVencedor(robo1, robo2);
        Console.WriteLine("Resultado: " + resultado);

        Robo robo3 = new RoboBatalhaPesado("Jurei");
        Robo robo4 = new RoboBatalhaPesado("Pagol");
        robo3.Iniciar();
        robo4.Iniciar();
        PartidaBatalha.Batalhar(robo3, robo4, 3);
        resultado = Resultado.DecideVencedor(robo3, robo4);
        Console.WriteLine("Resultado: " + resultado);


        Robo robo5 = new RoboBatalhaLeve("Geremias");
        Robo robo6 = new RoboBatalhaPesado("Pagol");
        robo5.Iniciar();
        robo6.Iniciar();
        PartidaBatalha.Batalhar(robo5, robo6, 9);
        resultado = Resultado.DecideVencedor(robo5, robo6);
        Console.WriteLine("Resultado: " + resultado);

    }
}



