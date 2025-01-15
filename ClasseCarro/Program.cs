using System;

namespace ClassesEObjetos
{
    class CarroProgram
    {
        public class Carro
        {
            public required string Nome {get; set;}
            public required string Marca {get; set;}
            public int Ano {get; set;}

            public string Acelerar()
            {
                return ("O carro está acelerando");
            }
        }

        static void Main(string[] args)
        {
            Carro carroA1 = new Carro {Nome = "MX5 Miata", Marca = "Mazda", Ano = 1996};

            Console.WriteLine($"Nome: {carroA1.Nome}");
            Console.WriteLine($"Marca: {carroA1.Marca}");
            Console.WriteLine($"Ano: {carroA1.Ano}");
            Console.WriteLine(carroA1.Acelerar());
        }
    }
}