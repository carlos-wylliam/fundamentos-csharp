using System;

namespace ImparOuPa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Olá, informe um número inteiro:");
            
            int number = int.Parse(Console.ReadLine());
            
            Console.Clear();

            string result = number % 2 == 0 ? "O número é par" : "O número é ímpar";
            Console.WriteLine(result);
        }
    }
}




