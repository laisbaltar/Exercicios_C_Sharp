using System;
using System.Globalization;

namespace Exercicio_Triangulo_Classes
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area(double largura, double altura)
        {
            return largura * altura;
        }

        public double Perimetro(double largura, double altura)
        {
            return 2 * largura + 2 * altura;
        }

        public double Diagonal(double largura, double altura)
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }

        public override string ToString()
        {
            return "AREA = "
                + Area(Largura, Altura).ToString("F2", CultureInfo.InvariantCulture)
                + " PERIMETRO = "
                + Perimetro(Largura, Altura).ToString("F2", CultureInfo.InvariantCulture)
                + " DIAGONAL = "
                + Diagonal(Largura, Altura).ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}