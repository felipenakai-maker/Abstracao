namespace Abstracao
{
    internal class ContaBancaria
    {
        public string Titular;
        public string NumeroConta;
        public double Saldo;

        public ContaBancaria(string titular, string numeroConta, double saldo = 0)
        {
            Titular = titular;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito inválido.");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido.");
                return;
            }

            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}
