using System;
namespace M2S04_Ex10;
public class Pessoa
{

    public Pessoa(string nome, int idade, double peso, double altura)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Peso = peso;
        this.Altura = altura;
        this.IMC = 0;

    }

    public string Nome { get; private set; }
    public int Idade { get; private set; }
    public double Peso { get; private set; }
    public double Altura { get; private set; }
    public double IMC { get; private set; }



    public double calculaIMC()
    {
        this.IMC = this.Peso / Math.Pow(this.Altura, 2);
        return this.IMC;
    }

    public string obterCategoriaIMC(double imc)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else
        {
            if (imc > 25)
            {
                return "Sobrepeso";

            }
            else
            {
                return "Peso normal";
            }
        }
    }





}