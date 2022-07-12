using M2S06_E1.Dominio;
using M2S06_E1.Exceptions;
using Xunit;

namespace M2S06_E6;

public class ContaTests
{
    private const string NumeroContaPadrao = "1234";
    private const double SaldoBase = 5000;
    private const double LimiteSaque = 500;

    private Conta CriarContaOperacional(bool operacional)
    {
        return new Conta(
            "1234",
            SaldoBase,
            LimiteSaque,
            operacional
        );
    }

    [Fact]
    public void Deveria_Cadastrar_Conta()
    {
        // Preparação
        var conta = CriarContaOperacional(true);

        // Validação do resultado
        Assert.NotNull(conta);
        Assert.Equal(conta.NumeroConta, NumeroContaPadrao);
    }

    [Fact]
    public void Deveria_Efetuar_Deposito()
    {
        // Preparação
        var valorDeposito = 500;
        var valorEsperado = 5500;
        var conta = CriarContaOperacional(true);

        // Execução
        conta.Depositar(valorDeposito);

        // Validação do resultado
        Assert.Equal(conta.Saldo, valorEsperado);
    }

    [Fact]
    public void Nao_Deveria_Efetuar_Deposito_Em_Conta_NaoOperacional()
    {
        Assert.Throws<ContaNaoOperacionalException>(() =>
        {
            // Preparação
            var valorDeposito = 500;
            var conta = CriarContaOperacional(false);

            // Execução
            conta.Depositar(valorDeposito);
        });
    }

    [Fact]
    public void Deveria_Efetuar_Saque()
    {
        // Preparação
        var valorSaque = 300;
        var valorEsperado = SaldoBase - valorSaque; //4700

        var conta = CriarContaOperacional(true);

        // Execução
        conta.Sacar(valorSaque);

        // Validação do resultado
        Assert.Equal(conta.Saldo, valorEsperado);
    }

    [Fact]
    public void Nao_Deveria_Efetuar_Saque_Quando_Valor_Eh_Maior_Que_Saldo()
    {
        Assert.Throws<ValorMaiorSaldoException>(() =>
        {
            // Preparação
            var valorSaque = SaldoBase + 100;

            var conta = CriarContaOperacional(true);

            // Execução
            conta.Sacar(valorSaque);
        });
    }

    [Fact]
    public void Nao_Deveria_Efetuar_Saque_Quando_Valor_Maior_LimiteSaque()
    {
        Assert.Throws<ValorMaiorLimiteException>(() =>
        {
            // Preparação
            var valorSaque = LimiteSaque + 100;

            var conta = CriarContaOperacional(true);

            // Execução
            conta.Sacar(valorSaque);
        });
    }
}