namespace M2S05
{
    public static class Resultado
    {
        public static string DecideVencedor(Robo robo1, Robo robo2)
        {
            string resultado = "";
            bool robo1Destruido = robo1.Status == Enums.EStatus.Destruído;
            bool robo2Vencedor = robo2.PontoVida > robo1.PontoVida;

            bool robo2Destruido = robo2.Status == Enums.EStatus.Destruído;
            bool robo1Vencedor = robo1.PontoVida > robo2.PontoVida;

            if (robo1Destruido || robo2Vencedor)
            {
                resultado = "O vencedor foi o jogador 2.";
            }
            else
            {
                if (robo2Destruido || robo1Vencedor)
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
