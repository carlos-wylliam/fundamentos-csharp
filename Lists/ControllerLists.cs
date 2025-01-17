using System;

namespace ListasExemplos
{
    public class Listas
    {
        private static List<string> products = new List<string>();
        public static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Informe um produto para ser adicionado no sistema:");

            string product = Console.ReadLine();
            products.Add(product);

            Console.WriteLine($"Produto '{product}' adicionado com sucesso!");
            Utils.VoltarMenu();
        }

        public static void ListProduct()
        {
            Console.Clear();
            if(products.Count == 0)
            {
                Console.WriteLine("A lista de produtos está vázia.");
            }
            else
            {
                Console.WriteLine("Produtos cadastrados:");
                foreach (var product in products)
                {
                    Console.WriteLine($"- {product}");
                }
            }
            Utils.VoltarMenu();
        }

        public static void RemoveProduct()
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do produto que deseja remover:");
            
            string product = Console.ReadLine();

            if (products.Remove(product))
            {
                Console.WriteLine($"Produto '{product}' removido com sucesso!");
            } else 
            {
                Console.WriteLine($"Produto '{product}' não encontrado na lista.");
            }
            Utils.VoltarMenu();
        }

        public static void VerifyContainsProduct()
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do produto para verificar:");
            string product = Console.ReadLine();
            if (products.Contains(product))
            {
                Console.WriteLine($"O produto '{product}' está na lista.");
            } else 
            {
                Console.WriteLine($"O produto '{product}' NÃO está na lista");
            }
             Utils.VoltarMenu();
        }

        
    }
}