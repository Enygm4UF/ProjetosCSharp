using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string nm1, nm2;
            int idade1, idade2;

            string[] vet = Console.ReadLine().Split(' ');
            nm1 = vet[0];
            idade1 = int.Parse(vet[1]);
            nm2 = vet[2];
            idade2 = int.Parse(vet[3]);
            double media = (double) (idade1 + idade2) / 2.0;
            Console.WriteLine("Média das idades: " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}