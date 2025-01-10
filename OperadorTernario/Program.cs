using System;
 namespace AgeRange
 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Informe a sua idade: ");
            
            int age = int.Parse(Console.ReadLine());
            
            Console.Clear();
            string result = age < 18 ? "Você é menor de idade": age <= 60 ? "Você é adulto" : "Você é idoso";
            Console.WriteLine(result);
        }
    }
 }