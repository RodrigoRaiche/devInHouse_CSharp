using M2S06_E3.Dominio;
using M2S06_E3.Exceptions;
using Xunit;

namespace M2S06_E8;

public class BoletimTestes
{
    private const string NumeroContaPadrao = "1234";
    private const double SaldoBase = 5000;
    private const double LimiteSaque = 500;

    private Aluno CriarAluno()
    {
        return new Aluno(101, "Rodrigo Raiche");
    }

    private Disciplina CriarDisciplina()
    {
        return new Disciplina("Cálculo número", 4);
    }

    private float[] CriarNotas()
    {
        float[] notas = new float[4];
        notas[0] = 10;
        notas[1] = 9;
        notas[2] = 8;
        notas[3] = 7;
        return notas;
    }

    [Fact]
    public void Deveria_Cadastrar_Boletim_Aluno()
    {
        // Preparação
        var aluno = CriarAluno();
        var disciplina = CriarDisciplina();
        var notas = CriarNotas();

        // Execução
        BoletimItem boletimItem = new BoletimItem(disciplina, notas);
        aluno.Boletim.Add(boletimItem);

        // Validação do resultado
        Assert.NotNull(boletimItem);
        Assert.True(aluno.Boletim.Count() > 0);
    }

    [Fact]
    public void Deveria_Calcular_Media_Notas_Aluno()
    {
        const float MediaPadrao = 8.5f;
        // Preparação
        var aluno = CriarAluno();
        var disciplina = CriarDisciplina();
        var notas = CriarNotas();

        // Execução
        BoletimItem boletimItem = new BoletimItem(disciplina, notas);
        aluno.Boletim.Add(boletimItem);

        // Validação do resultado
        Assert.Equal(aluno.Boletim[0].MediaNotas, MediaPadrao);
    }


}