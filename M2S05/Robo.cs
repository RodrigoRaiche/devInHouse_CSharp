using M2S05.Enums;

namespace M2S05
{
    public abstract class Robo
    {
        public Robo(string nomeRobo)
        {
            this.NomeRobo = nomeRobo;
            this.Status = EStatus.Desligado;
            this.PontoVida = 100;

        }

        public string NomeRobo { get; private set; }

        public int PontoVida { get; private set; }

        public EStatus Status { get; private set; }

        public void Iniciar()
        {
            this.Status = EStatus.Ligado;
        }

        public void Parar()
        {
            this.Status = EStatus.Desligado;
        }

        public void Aguardando()
        {
            this.Status = EStatus.Aguardando;
        }

        public abstract int CausarDano();

        public void ReduzirPontosVida(int pontoVidas)
        {
            if (pontoVidas > this.PontoVida)
            {
                this.PontoVida = 0;
            }
            else
            {
                this.PontoVida -= pontoVidas;
            }

            if (this.PontoVida == 0)
            {
                this.Status = EStatus.Destruído;
            }

        }


    }

}
