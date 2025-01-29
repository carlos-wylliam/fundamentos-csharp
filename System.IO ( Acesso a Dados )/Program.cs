using System;
using System.Data.SQLite;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=ProdutosDB.db";

        // Inserir produtos
        InserirProdutos(connectionString);

        // Listar produtos
        ListarProdutos(connectionString);

        // Remover produto pelo ID
        Console.WriteLine("Digite o ID do produto que deseja remover:");
        int idProduto = int.Parse(Console.ReadLine());
        RemoverProduto(connectionString, idProduto);

        // Listar produtos novamente após remoção
        ListarProdutos(connectionString);
    }

    // Função para inserir produtos
    static void InserirProdutos(string connectionString)
    {
       using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Produtos (Nome, Preco) VALUES (@Nome, @Preco)";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Inserir 3 produtos
                command.Parameters.AddWithValue("@Nome", "Produto 1");
                command.Parameters.AddWithValue("@Preco", 10.99);
                command.ExecuteNonQuery();

                command.Parameters.AddWithValue("@Nome", "Produto 2");
                command.Parameters.AddWithValue("@Preco", 20.49);
                command.ExecuteNonQuery();

                command.Parameters.AddWithValue("@Nome", "Produto 3");
                command.Parameters.AddWithValue("@Preco", 30.89);
                command.ExecuteNonQuery();
            }
            Console.WriteLine("Produtos inseridos com sucesso!\n");
        }
    }

    // Função para listar produtos
    static void ListarProdutos(string connectionString)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Produtos";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Lista de produtos:");
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nome = reader.GetString(1);
                        double preco = reader.GetDouble(2);

                        Console.WriteLine($"ID: {id}, Nome: {nome}, Preço:{preco}");
                    }
                }
            }
            Console.WriteLine(); // Linha em braco para separação
        }
    }

    // Função para remover produto pelo ID
    static void RemoverProduto(string connectionString, int idProduto)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Produtos WHERE ID = @ID";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", idProduto);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine($"Produto com ID {idProduto} removido com sucesso!");
                else
                    Console.WriteLine($"Produto com ID {idProduto} não encontrado");
            }
        }
    }
}