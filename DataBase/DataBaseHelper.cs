using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Financeiro_teste.DataBase
{
    public class DataBaseHelper
    {
        
        // Configurações de conexão padrão do XAMPP
        private static string host = "localhost";
        private static string database = "db_KamiKami";
        private static string user = "root";
        private static string password = ""; // Por padrão o XAMPP vem sem senha

        private static string connectionString = $"Server={host};Database={database};Uid={user};Pwd={password};";

        /// <summary>
        /// Tenta estabelecer a conexão com o banco.
        /// </summary>
        private static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Executa comandos de INSERT, UPDATE ou DELETE.
        /// </summary>
        public static int ExecutarComando(string sql, MySqlParameter[] parametros = null)
        {
            using (var conexao = GetConnection())
            {
                try
                {
                    conexao.Open();
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        if (parametros != null)
                            comando.Parameters.AddRange(parametros);

                        return comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao executar comando SQL: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Executa comandos de SELECT e retorna um DataTable.
        /// </summary>
        public static DataTable ExecutarConsulta(string sql, MySqlParameter[] parametros = null)
        {
            using (var conexao = GetConnection())
            {
                try
                {
                    conexao.Open();
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        if (parametros != null)
                            comando.Parameters.AddRange(parametros);

                        using (var adapter = new MySqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao consultar banco de dados: " + ex.Message);
                }
            }
        }
        
    }
}
