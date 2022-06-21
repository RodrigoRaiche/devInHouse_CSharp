static class Program
{
    static void Main(string[] args)
    {

        Conta conta1 = new Conta("Rodrigo", 125871L, 0D);
        Conta conta2 = new Conta("Liliane", 125882, 0);
        Conta conta3 = new Conta("Mikaela", 125895, 0);

        conta1.depositar(1000);
        conta2.depositar(500);
        conta3.depositar(750);

        conta1.sacar(500);
        conta2.sacar(250);

        conta1.sacar(500);
        conta1.depositar(100);

        Console.WriteLine($"O nome do títular da conta {conta1.obterNumero()} é {conta1.obterNomeCliente()}, seu saldo é R$: {conta1.obterSaldo()}");
        Console.WriteLine($"O nome do títular da conta {conta2.obterNumero()} é {conta2.obterNomeCliente()}, seu saldo é R$: {conta2.obterSaldo()}");
        Console.WriteLine($"O nome do títular da conta {conta3.obterNumero()} é {conta3.obterNomeCliente()}, seu saldo é R$: {conta3.obterSaldo()}");

    }
}