namespace M2S06_E3.Dominio
{
    public class Aluno
    {
        public int NumeroChamada { get; private set; }
        public string NomeAluno { get; private set; }

        public List<BoletimItem> Boletim { get; set; }

        public Aluno(int numeroChamada, string nomeAluno)
        {
            this.NumeroChamada = numeroChamada;
            this.NomeAluno = nomeAluno;
            this.Boletim = new List<BoletimItem> { };
        }
    }
}