using System;
using System.Reflection.Metadata;
using System.Text.Json;

class Program
{
    static async Task Main()
    {
        using HttpClient client = new HttpClient();

        string url = "https://jsonplaceholder.typicode.com/todos";

        try
        {
            // Requisição à API
            string response = await client.GetStringAsync(url);

            // Configuração para deserializar JSON
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Todo> todos = JsonSerializer.Deserialize<List<Todo>>(response, options);

            if (todos == null || !todos.Any())
            {
                Console.WriteLine("Nenhum dado foi retornado pela API.");
                return;
            }

            // Obtendo os primeiros 5 itens
            var primeirosCincoTodos = todos.Take(5).ToList();

            // Serializando em JSON formatado
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string jsonResult = JsonSerializer.Serialize(primeirosCincoTodos, jsonOptions);

            // Exibindo resultado
            Console.WriteLine(jsonResult);

        }
        catch (HttpRequestException ex)
        {
            
            Console.WriteLine($"Erro ao acessar a API: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroo inesperado: {ex.Message}");
        }
        
        
    }

    public class Todo 
    {
        public int Id { get; set;}
        public string Title {get; set;}
        public bool Completed {get; set;}
    }
}
