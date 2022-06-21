static class Program
{
    static void Main(string[] args)
    {

        Lampada lampadaLed = new Lampada("LED", "Externo", 11, 1018, "Philips", "Branco neutro", 220);

        lampadaLed.liga();
        while (lampadaLed.Estado)
        {
            lampadaLed.mostraEstado();
            lampadaLed.liga();

        }

    }
}