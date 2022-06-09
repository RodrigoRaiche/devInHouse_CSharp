public enum opcoesBancaria
{
    Saldo,
    Depósito,
    Saque,
    Histórico,
    Sair
}

public class Operacao
{
    public Operacao() { }

    public opcoesBancaria OperacaoRealizada;
    public float ValorOperacao;
    public DateTime DataHora;

    public Operacao(opcoesBancaria operacaoRealizada, float valorOperacao, DateTime dataHora)
    {
        this.OperacaoRealizada = operacaoRealizada;
        this.ValorOperacao = valorOperacao;
        this.DataHora = dataHora;
    }
}

class CalculadoraAplicacaoBancaria
{

    static List<Operacao> operacoes;
    public static void Main(string[] args)
    {
        operacoes = new List<Operacao>();

        opcoesBancaria opcaoEscolhida = obterEscolha();
        float saldoConta = 0;

        while (opcaoEscolhida != opcoesBancaria.Sair)
        {
            if (validarOpcao(opcaoEscolhida))
            {
                exibeMensagem("Opção inválida");

            }
            else
            {
                switch (opcaoEscolhida)
                {
                    case opcoesBancaria.Saldo:
                        exibirSaldo(saldoConta);
                        break;
                    case opcoesBancaria.Depósito:
                        saldoConta = realizaDeposito(saldoConta);
                        break;
                    case opcoesBancaria.Saque:
                        saldoConta = realizaSaque(saldoConta);
                        break;
                    case opcoesBancaria.Histórico:
                        exibeHistorico(saldoConta);
                        break;
                }

            }

            opcaoEscolhida = obterEscolha();

        }
    }

    private static bool validarOpcao(opcoesBancaria opcao)
    {
        if (opcao != opcoesBancaria.Saldo &&
            opcao != opcoesBancaria.Saque &&
            opcao != opcoesBancaria.Depósito &&
            opcao != opcoesBancaria.Histórico &&
            opcao != opcoesBancaria.Sair)
        {
            return true;
        }
        return false;

    }

    private static opcoesBancaria obterEscolha()
    {
        exibirOpcoesMenu();

        Console.Write("Escolha a opção: ");
        return (opcoesBancaria)int.Parse(Console.ReadLine());
    }

    private static void exibirOpcoesMenu()
    {
        Console.WriteLine("Opções da Aplicação Bancária");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("--------------------------------------------------------------");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Opção {i} - {(opcoesBancaria)i}");
        }
        Console.WriteLine("--------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void exibirSaldo(float saldo)
    {
        Console.WriteLine("--------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"O saldo da conta é R$: {saldo}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("--------------------------------------------------------------");

    }

    private static float realizaDeposito(float saldo)
    {
        float valorDeposito = 0;
        Console.Write("Digite o valor a ser depositado R$: ");
        valorDeposito = float.Parse(Console.ReadLine());

        if (valorDeposito <= 0)
        {
            exibeMensagem("Valor inválido");

        }
        else
        {
            saldo += valorDeposito;
            registraOperacao(opcoesBancaria.Depósito, valorDeposito);

        }


        return saldo;

    }

    private static float realizaSaque(float saldo)
    {
        float valorSaque = 0;
        Console.Write("Digite o valor do Saque R$: ");
        valorSaque = float.Parse(Console.ReadLine());

        if (valorSaque > saldo)
        {
            exibeMensagem("Você não tem saldo suficiente");

        }
        else
        {
            saldo -= valorSaque;
            registraOperacao(opcoesBancaria.Saque, valorSaque);
        }


        return saldo;

    }

    private static void exibeMensagem(string mensagem)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine(mensagem);
        Console.WriteLine("--------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void registraOperacao(opcoesBancaria operacao, float valorOperacao)
    {
        operacoes.Add(new Operacao(operacao, valorOperacao, DateTime.Now));

    }

    private static void exibeHistorico(float saldo)
    {

        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("Extrato da conta");
        foreach (Operacao linhaOperacao in operacoes)
        {
            Console.WriteLine("--------------------------------------------------------------");
            if (linhaOperacao.OperacaoRealizada == opcoesBancaria.Depósito)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Foi realizado {linhaOperacao.OperacaoRealizada} as {linhaOperacao.DataHora} no valor R$ {linhaOperacao.ValorOperacao}");
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine($"Saldo total R$ {saldo}");
        Console.WriteLine("--------------------------------------------------------------");

        Console.ForegroundColor = ConsoleColor.White;
    }


}
