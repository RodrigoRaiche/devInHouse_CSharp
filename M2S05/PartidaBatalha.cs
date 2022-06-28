using System;

namespace M2S05
{
    public static class PartidaBatalha
    {
        public static int Batalhar(Robo robo1, Robo robo2, int qtdPartida)
        {
            int roboVencedor = 0;
            int contpartida = 0;

            while (roboVencedor == 0 && contpartida < qtdPartida)
            {

                robo1.ReduzirPontosVida(robo1.CausarDano());
                robo2.ReduzirPontosVida(robo2.CausarDano());

                if (robo1.Status == Enums.EStatus.Destruído)
                {
                    roboVencedor = 2;
                }

                if (robo2.Status == Enums.EStatus.Destruído)
                {
                    roboVencedor = 1;
                }

                Console.WriteLine($"Robô 1 - {robo1.NomeRobo} com {robo1.PontoVida} pontos");
                Console.WriteLine($"Robô 2 - {robo2.NomeRobo} com {robo2.PontoVida} pontos");

                contpartida++;
            }

            if (roboVencedor == 0)
            {
                if (robo1.PontoVida > robo2.PontoVida)
                {
                    roboVencedor = 1;
                }
                else
                {
                    if (robo2.PontoVida > robo1.PontoVida)
                    {
                        roboVencedor = 2;
                    }

                }

            }

            return roboVencedor;


        }
    }
}