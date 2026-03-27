using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do terreno retangular: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a altura do terreno retangular: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do metro quadrado: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * altura;
            double preco = area * valor;

            Console.WriteLine("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}