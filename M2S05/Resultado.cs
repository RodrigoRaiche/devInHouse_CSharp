namespace M2S05
{
    public static class Resultado
    {
        public static string DecideVencedor(Robo robo1, Robo robo2)
        {
            string resultado = "";

            if (robo1.Status == Enums.EStatus.Destruído || robo2.PontoVida > robo1.PontoVida)
            {
                resultado = "O vencedor foi o jogador 2.";
            }
            else
            {
                if (robo2.Status == Enums.EStatus.Destruído || robo1.PontoVida > robo2.PontoVida)
                {
                    resultado = "O vencedor foi o jogador 1.";
                }
                else
                {
                    resultado = "O jogo empatou.";
                }
            }

            return resultado;


        }

    }
}
