using M2S06_E1.Expections;

namespace M2S06_E1.Dominio
{
    public class Conta
    {
        public string NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public double Limite { get; private set; }
        public bool Operacional { get; private set; }

        public Conta(string numeroConta, double saldo, double limite, bool operacional)
        {
            this.NumeroConta = numeroConta;
            this.Saldo = saldo;
            this.Limite = limite;
            this.Operacional = operacional;
        }

        private void VerificaContaEstadoOperacional()
        {
            if (!Operacional) throw new ContaNaoOperacionalException(this.NumeroConta);

        }

        public double ObterSaldo()
        {
            VerificaContaEstadoOperacional();

            return this.Saldo;
        }


        public void Sacar(double valor)
        {

            VerificaContaEstadoOperacional();

            if (valor <= 0)
            {
                throw new ValorOperacaoZeradoOuNegativoException(this.NumeroConta);
            }


            if (valor > this.Saldo)
            {
                throw new ValorMaiorSaldoException(this.NumeroConta);
            }


            if (valor > this.Limite)
            {
                throw new ValorMaiorLimiteException(this.NumeroConta);
            }

            this.Saldo -= valor;

        }

        public void Depositar(double valor)
        {

            VerificaContaEstadoOperacional();

            if (valor <= 0)
            {
                throw new ValorOperacaoZeradoOuNegativoException(this.NumeroConta);
            }

            this.Saldo += valor;
        }

    }
}