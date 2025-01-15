using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Informe um número para a sequência");
            int numero = int.Parse(Console.ReadLine());

            int primeiroNumero = 0;
            int segundoNumero = 1;

            Console.WriteLine("Sequência de Fibonacci:");

            Console.WriteLine(primeiroNumero);

            for (int i = 1; i <= numero ; i++)
            {
                Console.WriteLine(segundoNumero);

                int proximoNumero = primeiroNumero + segundoNumero;

                primeiroNumero = segundoNumero;
                segundoNumero = proximoNumero;
            }
        }
    }
}


