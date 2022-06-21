public class Conta
{

    public Conta(string nomeCliente, long numeroConta, double saldo)
    {
        this.NomeCliente = nomeCliente;
        this.NumeroConta = numeroConta;
        this.Saldo = saldo;

    }
    public string NomeCliente { get; private set; }
    public long NumeroConta { get; private set; }
    public double Saldo { get; private set; }

    public void depositar(double valor)
    {
        this.Saldo += valor;
    }

    public void sacar(double valor)
    {
        if (valor <= this.Saldo)
        {
            this.Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficente para o saque");
        }

    }

    public double obterSaldo()
    {
        return this.Saldo;
    }

    public long obterNumero()
    {
        return this.NumeroConta;
    }

    public string obterNomeCliente()
    {
        return this.NomeCliente;
    }


}