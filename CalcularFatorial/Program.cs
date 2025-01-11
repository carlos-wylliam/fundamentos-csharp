using System;
using System.Diagnostics;

namespace FactorialCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Informe um número inteiro positivo");

            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"O fatorial do número {number} é {factorial}");

        }
    }
}

