namespace M2S05
{
    public class RoboBatalhaPesado : Robo
    {
        public RoboBatalhaPesado(string nomeRobo) : base(nomeRobo)
        {
        }

        public override int CausarDano()
        {
            this.Aguardando();
            return 20;
        }
    }
}