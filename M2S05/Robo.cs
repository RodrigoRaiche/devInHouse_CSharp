using M2S05.Enums;

namespace M2S05
{
    public abstract class Robo
    {
        public string NomeRobo { get; set; }

        public int PontoVida
        {
            get { return PontoVida; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Valor inválido");
                }
                PontoVida = value;
            }
        }


        public EStatus Status { get; private set; }

        public void Iniciar()
        {
            this.Status = EStatus.Ligado;
        }

        public void Parar()
        {
            this.Status = EStatus.Desligado;
        }

        public abstract int CausarDano();

        public void ReduzirPontosVida(int pontoVidas)
        {
            this.PontoVida -= pontoVidas;

            if (this.PontoVida == 0)
            {
                this.Status = EStatus.Destruído;
            }

        }


    }

}
