namespace M2S06_E3.Dominio
{
    public class Disciplina
    {
        public string NomeDisciplina { get; private set; }
        public int QtdAvaliacoes { get; private set; }

        public Disciplina(string nomeDisciplina, int qtdAvaliacoes)
        {
            this.NomeDisciplina = nomeDisciplina;
            this.QtdAvaliacoes = qtdAvaliacoes;

        }
    }
}