using M2S05;

public static class Program
{
    public static void Main(string[] args)
    {

        Robo robo1 = new RoboBatalhaPesado("Eliot");
        Robo robo2 = new RoboBatalhaLeve("Geremias");

        robo1.Iniciar();
        robo2.Iniciar();

        int vencedor = PartidaBatalha.Batalhar(robo1, robo2, 4);

        Console.WriteLine("O vencedor foi o jogador " + vencedor);

    }
}



