using System;
using System.Globalization;

namespace ExercicioSeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, resto;
            int n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600;
            int minutos = resto / 60;
            int segundos = resto % 60;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}