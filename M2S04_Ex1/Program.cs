static class Program
{
    static void Main(string[] args)
    { 

        Lampada lampadaLed = new Lampada("LED","Externo", 11,1018, "Philips", "Branco neutro");
        lampadaLed.liga();
        lampadaLed.mostraEstado();
        lampadaLed.desliga();
        lampadaLed.mostraEstado();
    }
}