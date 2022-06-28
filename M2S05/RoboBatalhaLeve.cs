namespace M2S05
{
    public class RoboBatalhaLeve : Robo
    {
        public override int CausarDano()
        {
            int valorDano = 0;

            if (this.Status == Enums.EStatus.Ligado)
            {
                valorDano = 10;
            }

            return valorDano;
        }


    }
}