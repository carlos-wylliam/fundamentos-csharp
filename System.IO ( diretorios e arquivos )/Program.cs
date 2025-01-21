using System;
using System.ComponentModel.Design;
using System.IO;

namespace ManipulationFolderFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string path = Path.Combine(desktopPath, "Projetos");
                string pathFile = Path.Combine(path, "meusProjetos.txt");

                // Criando o diretório
                CriarDiretorio(path);

                // Criando e escrevendo no arquivo
                CriarArquivo(pathFile);

                // Lendo o arquivo
                LerArquivo(pathFile);

                // Perguntando antes de excluir
                Console.WriteLine("\nDeseja excluir o arquivo e o diretorio? (s/n)");
                if (Console.ReadLine().Trim().ToLower() == "s")
                {
                    ExcluirArquivo(pathFile);
                    Console.WriteLine("Arquivo excluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("Exclusão cancelada.");
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }

            static void CriarDiretorio(string path)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Diretório criado com sucesso!");
                }
                else
                {
                    Console.WriteLine("O diretório já existe.");
                }
                
            }

            static void CriarArquivo(string pathFile)
            {
                string content = "Calculadora\nEditor de textos\nImpar ou pá\nListas\nClasses\nFibonacci";
                File.WriteAllText(pathFile, content);
                Console.WriteLine("Arquivo criado e conteúdo gravado com sucesso!");
            }

            static void LerArquivo(string pathFile)
            {
                string content = File.ReadAllText(pathFile);
                Console.WriteLine("\nConteúdo do arquivo:");
                Console.WriteLine(content);
            }

            static void ExcluirArquivo(string pathFile)
            {
                File.Delete(pathFile);
            }
        }
    }
}

