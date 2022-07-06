using System;
using System.Globalization;

namespace Salario_Exercicio_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa = new Funcionario();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: "
                + pessoa.Nome
                + " , R$ "
                + pessoa.SalarioLiquido());

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            pessoa.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
        }
    }
}