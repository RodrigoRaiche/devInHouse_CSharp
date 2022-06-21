public class PotenciaLampada
{

    public PotenciaLampada(int valor, int voltagem)
    {
        this.Valor = valor;
        this.Voltagem = voltagem;
    }
    public int Valor { get; private set; }

    public int Voltagem { get; private set; }

  
    public void setValor(int valor){
        this.Valor = valor;
    }
    
    public void setVoltagem(int voltagem){
        this.Voltagem = voltagem;
    }

}