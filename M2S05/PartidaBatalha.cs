using System;

namespace M2S05
{
    public static class PartidaBatalha
    {
        public static void Batalhar(Robo robo1, Robo robo2, int qtdPartida)
        {
            bool acabouPartida = false;
            int contpartida = 0;

            while (acabouPartida == false && contpartida < qtdPartida)
            {

                if (robo1.Status == Enums.EStatus.Ligado)
                {
                    robo2.ReduzirPontosVida(robo1.CausarDano());
                }
                else
                {
                    robo1.Iniciar();
                }


                if (robo2.Status == Enums.EStatus.Ligado)
                {
                    robo1.ReduzirPontosVida(robo2.CausarDano());
                }
                else
                {
                    robo2.Iniciar();
                }

                if (robo1.Status == Enums.EStatus.Destruído ||
                robo2.Status == Enums.EStatus.Destruído)
                {
                    acabouPartida = true;
                }

                Console.WriteLine($"Robô 1 - {robo1.NomeRobo} com {robo1.PontoVida} pontos");
                Console.WriteLine($"Robô 2 - {robo2.NomeRobo} com {robo2.PontoVida} pontos");

                contpartida++;
            }


        }
    }
}