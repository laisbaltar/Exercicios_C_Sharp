using System.Globalization;

namespace Exercicio_Conta_Bancaria
{
    internal class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroDaConta, string titular, double depositoInicial) : this(numeroDaConta, titular)
        {
            Deposito(depositoInicial);
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            // 5 reais de taxa por saque
            Saldo -= quantia + 5;
        }
    }
}
