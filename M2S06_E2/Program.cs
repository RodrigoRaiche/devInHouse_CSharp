using M2S06_E2;
using M2S06_E2.Exceptions;

while (true)
{
    Output.ExibirOperacoes();
    try
    {
        ECalculadora operacaoEscolhida = (ECalculadora)Output.EscolherOperacao();
        double valor1 = Output.DefinirValor();
        double valor2 = Output.DefinirValor();

        double resultado;
        switch (operacaoEscolhida)
        {
            case ECalculadora.Soma:
                resultado = Calculadora.Somar(valor1, valor2);
                break;
            case ECalculadora.Subtracao:
                resultado = Calculadora.Subtrair(valor1, valor2);
                break;
            case ECalculadora.Multiplicacao:
                resultado = Calculadora.Multiplicar(valor1, valor2);
                break;
            case ECalculadora.Divisao:
                resultado = Calculadora.Dividir(valor1, valor2);
                break;
            default:
                resultado = 0;
                break;
        }

        Output.ExibirResultado(resultado);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message, e.InnerException);
    }
}
