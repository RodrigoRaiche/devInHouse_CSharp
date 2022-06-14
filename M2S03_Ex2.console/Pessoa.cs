public class Pessoa{

    public Pessoa(string nome,
                  DateTime dataNascimento,
                  double altura,
                  double peso)
    {
        this.Nome = nome;
        this.DataNascimento = dataNascimento;
        this.Altura = altura;
        this.Peso = peso;
        
    }
    public string Nome {get;private set;}
    public DateTime DataNascimento {get; private set;}
    public double Altura {get;private set;}
    public double Peso {get;private set;}

    public void visualizarDados(){
        Console.WriteLine($"Olá {this.Nome} que tem altura de {this.Altura} metros, pesa {this.Peso} kg e nasceu em {this.DataNascimento}");
    }
}