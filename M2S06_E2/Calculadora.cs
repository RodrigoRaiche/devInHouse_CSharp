using M2S06_E2.Exceptions;

namespace M2S06_E2
{
    public class Calculadora
    {
        public static double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public static double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public static double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public static double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0) throw new DivisaoporZeroException();
            return valor1 / valor2;
        }
    }
}
