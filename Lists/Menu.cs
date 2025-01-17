using System;
using System.ComponentModel.Design;
using System.Text.Json;

namespace ListasExemplos
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            WriteOptions();

            Console.WriteLine("\nEscolha uma opção:");
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void WriteOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar um produto.");
            Console.WriteLine("2 - Listar todos os produtos.");
            Console.WriteLine("3 - Remover um produto.");
            Console.WriteLine("4 - Verificar se um produto está na lista.");
            Console.WriteLine("5 - Sair.");
        }

        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1: Listas.AddProduct(); break;
                case 2: Listas.ListProduct(); break;
                case 3: Listas.RemoveProduct(); break;
                case 4: Listas.VerifyContainsProduct(); break;
                case 5: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}