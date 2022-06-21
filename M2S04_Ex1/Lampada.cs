public class Lampada
{

    public Lampada(string tipoLuz, string tipoAmbiente, int potencia, int fluxoLuminoso,
                   string marca, string temperaturaCor, bool estado = false)
    {

        this.TipoLuz = tipoLuz;
        this.TipoAmbiente = tipoAmbiente;
        this.Potencia = potencia;
        this.FluxoLuminoso = fluxoLuminoso;
        this.Marca = marca;
        this.TemperaturaCor = temperaturaCor;
        this.Estado = estado;
    }
    public string TipoLuz { get; private set; }
    public string TipoAmbiente { get; private set; }

    public int Potencia { get; private set; }

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

}