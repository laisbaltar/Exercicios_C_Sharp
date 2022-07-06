using System;
using System.Globalization;

namespace Salario_Exercicio_Classes
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100;
            Console.WriteLine("Dados atualizados: "
                + Nome
                + " , R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}