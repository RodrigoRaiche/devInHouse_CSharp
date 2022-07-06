namespace M2S06_E3.Dominio
{
    public class BoletimPorDisciplina
    {
        public Disciplina DisciplinaBoletim { get; private set; }
        public float MediaNotas { get; private set; }
        public float[] Notas { get; set; }

        public BoletimPorDisciplina(Disciplina disciplinaBoletim, float[] notas)
        {
            this.DisciplinaBoletim = disciplinaBoletim;
            this.Notas = notas;
            this.MediaNotas = Notas.Average();
        }
    }
}