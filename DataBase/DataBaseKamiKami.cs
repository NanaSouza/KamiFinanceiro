using System;
using System.Data;
using MySql.Data.MySqlClient; // Certifique-se de ter instalado o pacote MySql.Data via NuGet

public class DatabaseHelper
{
    // Configurações do XAMPP
    private string connectionString = "Server=localhost;Database=db_restaurante_yakissoba;Uid=root;Pwd=;";

    public DatabaseHelper()
    {
        CriarTabelas();
    }

    private void CriarTabelas()
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();

            // Tabela Produtos (MySQL usa AUTO_INCREMENT)
            string sqlProdutos = @"
                CREATE TABLE IF NOT EXISTS Produtos (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    Nome VARCHAR(100) NOT NULL,
                    Preco DECIMAL(10,2) NOT NULL,
                    Categoria VARCHAR(50),
                    Estoque INT DEFAULT 0
                )";

            // Tabela Vendas
            string sqlVendas = @"
                CREATE TABLE IF NOT EXISTS Vendas (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    DataHora DATETIME NOT NULL,
                    Total DECIMAL(10,2) NOT NULL,
                    FormaPagamento VARCHAR(50),
                    Status VARCHAR(20)
                )";

            // Tabela ItensVenda
            string sqlItensVenda = @"
                CREATE TABLE IF NOT EXISTS ItensVenda (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    VendaId INT,
                    ProdutoId INT,
                    Quantidade INT,
                    PrecoUnitario DECIMAL(10,2),
                    FOREIGN KEY(VendaId) REFERENCES Vendas(Id)
                )";

            // Tabela Despesas
            string sqlDespesas = @"
                CREATE TABLE IF NOT EXISTS Despesas (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    Data DATETIME NOT NULL,
                    Categoria VARCHAR(50),
                    Descricao TEXT,
                    Valor DECIMAL(10,2) NOT NULL,
                    FormaPagamento VARCHAR(50)
                )";

            // Executando a criação das tabelas
            using (var cmd = new MySqlCommand(sqlProdutos, conn)) cmd.ExecuteNonQuery();
            using (var cmd = new MySqlCommand(sqlVendas, conn)) cmd.ExecuteNonQuery();
            using (var cmd = new MySqlCommand(sqlItensVenda, conn)) cmd.ExecuteNonQuery();
            using (var cmd = new MySqlCommand(sqlDespesas, conn)) cmd.ExecuteNonQuery();

            InserirProdutosPadrao(conn);
        }
    }

    private void InserirProdutosPadrao(MySqlConnection conn)
    {
        // Verifica se a tabela está vazia antes de inserir
        string checkSql = "SELECT COUNT(*) FROM Produtos";
        using (var cmdCheck = new MySqlCommand(checkSql, conn))
        {
            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count == 0)
            {
                // Lista de produtos para o cardápio
                var produtos = new[]
                {
                    new { Nome = "Yakissoba Tradicional", Preco = 35.00, Categoria = "Yakissoba" },
                    new { Nome = "Yakissoba de Frango", Preco = 32.00, Categoria = "Yakissoba" },
                    new { Nome = "Yakissoba de Carne", Preco = 38.00, Categoria = "Yakissoba" },
                    new { Nome = "Yakissoba Vegetariano", Preco = 30.00, Categoria = "Yakissoba" },
                    new { Nome = "Refrigerante Lata", Preco = 5.00, Categoria = "Bebida" },
                    new { Nome = "Suco Natural", Preco = 7.00, Categoria = "Bebida" },
                    new { Nome = "Água Mineral", Preco = 3.00, Categoria = "Bebida" },
                    new { Nome = "Harumaki (6 unid)", Preco = 12.00, Categoria = "Acompanhamento" },
                    new { Nome = "Guioza (6 unid)", Preco = 15.00, Categoria = "Acompanhamento" }
                };

                string insertSql = "INSERT INTO Produtos (Nome, Preco, Categoria) VALUES (@nome, @preco, @categoria)";
                foreach (var p in produtos)
                {
                    using (var insertCmd = new MySqlCommand(insertSql, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@nome", p.Nome);
                        insertCmd.Parameters.AddWithValue("@preco", p.Preco);
                        insertCmd.Parameters.AddWithValue("@categoria", p.Categoria);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}