using M2S06_E2.Exceptions;

string opcao = " ";

while (opcao != "9")
{
    try
    {
        Console.WriteLine("Informe a operação desejada(+,-,/,*) ou digite 9 para sair");

        opcao = Console.ReadLine();

        if (opcao != "+" && opcao != "-" && opcao != "*" && opcao != "/" && opcao != "9")
        {
            throw new OpcaoInvalidaException(opcao.ToString());
            continue;
        }

        if (opcao != "9")
        {
            Console.Write("Informe o valor 1: ");
            var valor1Valido = double.TryParse(Console.ReadLine(), out var valor1Informado);
            if (!valor1Valido)
            {
                throw new ValorInvalidaException();
                continue;
            }
            Console.Write("Informe o valor 2: ");
            var valor2Valido = double.TryParse(Console.ReadLine(), out var valor2Informado);
            if (!valor2Valido)
            {
                throw new ValorInvalidaException();
                continue;

            }
            if (valor2Informado == 0)
            {
                throw new DivisaoporZeroException();
                continue;
            }

            double resultado = 0;
            switch (opcao)
            {
                case "+":
                    resultado = valor1Informado + valor2Informado;
                    break;
                case "-":
                    resultado = valor1Informado - valor2Informado;
                    break;
                case "/":
                    resultado = valor1Informado / valor2Informado;
                    break;
                case "*":
                    resultado = valor1Informado * valor2Informado;
                    break;

            }
            Console.WriteLine($"Resultado: {valor1Informado} {opcao} {valor2Informado} = {resultado}  ");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exceção {e.GetType().Name} captura com a mensagem {e.Message}");
        continue;
    }


}

