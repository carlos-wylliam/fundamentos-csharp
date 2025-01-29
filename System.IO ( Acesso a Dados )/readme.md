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