namespace M2S05
{
    public static class PartidaBatalha
    {
        public static int Batalhar(Robo robo1, Robo robo2)
        {
            int roboVencedor = 0;

            robo1.ReduzirPontosVida(robo1.CausarDano());
            robo2.ReduzirPontosVida(robo2.CausarDano());

            if (robo1.Status == Enums.EStatus.Destruído)
            {
                roboVencedor = 1;
            }

            if (robo2.Status == Enums.EStatus.Destruído)
            {
                roboVencedor = 2;
            }

            return roboVencedor;


        }
    }
}