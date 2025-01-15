using System;

namespace ClassesEObjetos
{
    class Program
    {
        public class Pessoa
        {
            public required string Nome {get; set;}
            public DateTime DataDeNascimento {get; set;}

            public int CalcularIdade()
            {
                int idade = DateTime.Now.Year - DataDeNascimento.Year;
                if (DateTime.Now.DayOfYear < DataDeNascimento.DayOfYear)
                    idade--;
                return idade;
            }
        }

        static void Main(string[] args)
        {
            Pessoa pessoaA1 = new Pessoa { Nome = "Carlos", DataDeNascimento = new DateTime(2004, 1, 23) };

            Console.WriteLine($"Nome: {pessoaA1.Nome}");
            Console.WriteLine($"Data de nascimento: {pessoaA1.DataDeNascimento.ToShortDateString()}");
            Console.WriteLine($"Idade: {pessoaA1.CalcularIdade()}");
        }
    }
}