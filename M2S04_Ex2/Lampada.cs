public class Lampada
{

    public Lampada(string tipoLuz, string tipoAmbiente, int potencia, int fluxoLuminoso,
                   string marca, string temperaturaCor, int voltagem, bool estado = false)
    {

        this.TipoLuz = tipoLuz;
        this.TipoAmbiente = tipoAmbiente;
        this.FluxoLuminoso = fluxoLuminoso;
        this.Marca = marca;
        this.TemperaturaCor = temperaturaCor;
        this.Estado = estado;

        this.Potencia = new PotenciaLampada(potencia, voltagem);

    }
    public string TipoLuz { get; private set; }
    public string TipoAmbiente { get; private set; }

    public PotenciaLampada Potencia { get; private set; }

    public int FluxoLuminoso { get; private set; }

    public string Marca { get; private set; }

    public string TemperaturaCor { get; private set; }

    public bool Estado { get; private set; }

    public void mostraEstado()
    {
        Console.WriteLine("O estado da lâmpada é " + (this.Estado ? "Ligado" : "Desligado"));
    }

    public void liga()
    {
        this.Estado = true;
    }

    public void desliga()
    {
        this.Estado = false;
    }

    public void mostraPotencia()
    {
        Console.WriteLine($"A potência da lâmpada é {this.Potencia.Valor} watts e sua voltagem é {this.Potencia.Voltagem} V" );
    }

    public void alteraPotencia(int valor, int voltagem)
    {
        Potencia.setValor(valor);
        Potencia.setVoltagem(voltagem);
    }


}