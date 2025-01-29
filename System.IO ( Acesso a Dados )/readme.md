# Anotações  

## Como criar um banco de dados usando SQLite e se conectar usando ADO.NET  

### 1. Criar um arquivo `.db`  
- Exemplo: `produtosDB.db`.  

### 2. Abrir o terminal e criar a tabela  
Execute o seguinte comando SQL:  

```sql
CREATE TABLE Produtos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    Nome TEXT NOT NULL,
    Preco REAL NOT NULL
);
````
### 3. Inserir os dados na tabela
Execute o seguinte comando SQL:
```sql
INSERT INTO Produtos (Nome, Preco)
VALUES
    ('Café Pilão', 14.50),
    ('Arroz Tio João', 23.90),
    ('Feijão Preto', 8.75);
````

### 4. Instalar o pacote NuGet System.Data.SQLite
```hash
    dotnet add package System.Data.SQLite
````

# Anotações sobre o código
## Using
O using é utilizado para garantir que objetos que implementam a interface IDisposable sejam corretamente fechados/liberados após o uso. No caso do SQlite, isso significa que a conexão com o banco de dados será fechada automaticamente quando o bloco using terminar.

## O que é SQLiteConnection?
SQLiteConnection é uma classe do proprio SQLite que representa uma conexão com o banco de dados.
### Como funciona?
- Quando você cria uma instância de SQLiteConnection, está preparando uma conexão com o banco
- Você precisa passar a string de conexão como argumento (exemplo: "Data Source=ProdutosDB.db").
- Para de fato conectar ao banco, você chama connection.Open().

## O que faz command.ExecuteNonQuery()?
O método ExecuteNonQuery() executa comandos SQL que não retornam resultados ( como INSERT, UPDATE, DELETE, e CREATE TABLE).

## O que é SQLiteDataReader e ExecuteReader()?
SQLiteDataReader é uma classe usada para ler os resultados de consultas SELECT.
### Como funciona ExcuteReader()?
O método ExecuteReader() executa uma consulta SELECT e retorna um objeto SQLiteDataReader, que pode ser usado para percorrer os resultados linha por linha.
