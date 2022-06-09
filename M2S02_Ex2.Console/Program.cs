/*2. Crie um programa 
**Entrada: ** notas de 6 alunos e mostre como.
**Saída:**  deve mostrar a média da nota da prova e o total de quantos 
tiveram nota maior que 7; nota menor que 7 e maior que 0 e notas igual a 0.*/

/*float[] notas = new float[6];
float somaNotas = 0;
int qtdMaior7 = 0;
int qtdMenor7 = 0;
int qtdZeros = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write($"Digite a nota do aluno {i+1} : ");
    notas[i] = float.Parse(Console.ReadLine());

    somaNotas += notas[i];
    if (notas[i] >= 7)
    {
        qtdMaior7++;
    }
    else if (notas[i] == 0)
    {
        qtdZeros++;
    }
    else
    {
        qtdMenor7++;
    }
}

float mediaNotas = somaNotas / 6;

Console.WriteLine($"A turma teve média {mediaNotas}.");
Console.WriteLine($"Tiveram {qtdMaior7} alunos com nota maior ou igual a 7.");
Console.WriteLine($"Tiveram {qtdMenor7} alunos com nota menor 7 e diferente de 0.");
Console.WriteLine($"Tiveram {qtdZeros} alunos com nota igual a zero.");*/


float[] notas = new float[6];
int qtdMaior7 = 0;
int qtdMenor7 = 0;
int qtdZeros = 0;

for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Digite a nota do aluno {i+1} : ");
    notas[i] = float.Parse(Console.ReadLine());

    if (notas[i] >= 7)
    {
        qtdMaior7++;
    }
    else if (notas[i] == 0)
    {
        qtdZeros++;
    }
    else
    {
        qtdMenor7++;
    }
}

//float mediaNotas = notas.Sum() / notas.Length;
float mediaNotas = notas.Average();

Console.WriteLine($"A turma teve média {mediaNotas}.");
Console.WriteLine($"Tiveram {qtdMaior7} alunos com nota maior ou igual a 7.");
Console.WriteLine($"Tiveram {qtdMenor7} alunos com nota menor 7 e diferente de 0.");
Console.WriteLine($"Tiveram {qtdZeros} alunos com nota igual a zero.");
