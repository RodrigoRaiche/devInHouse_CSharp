namespace M2S05
{
    public class RoboBatalhaPesado : Robo
    {
        public override int CausarDano()
        {
            this.Aguardando();
            return 20;
        }
    }
}