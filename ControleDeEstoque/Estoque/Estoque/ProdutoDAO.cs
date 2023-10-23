using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class ProdutoDAO // internal = só pode ser acessada dentro do projeto
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public ProdutoDAO() // Construtor
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
            Cmd.Connection = Con.ReturnConnection(); 
        }
        public void Inserir(Produto produto) // Método para inserir um produto no banco de dados
        {
            using (SqlConnection connection = Con.ReturnConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Produto VALUES (@ID, @Nome, @Fornecedor, @Categoria, @Unidade, @Preco, @Quantidade, @Descricao)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", produto.ID);
                command.Parameters.AddWithValue("@Nome", produto.Nome);
                command.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
                command.Parameters.AddWithValue("@Categoria", produto.Categoria);
                command.Parameters.AddWithValue("@Unidade", produto.Unidade);
                command.Parameters.AddWithValue("@Preco", produto.Preco);
                command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                command.ExecuteNonQuery();
            }
        }


        public void Atualizar(Produto produto) // Método para atualizar um produto no banco de dados
        {
            using (SqlConnection connection = Con.ReturnConnection())
            {
                connection.Open();
                string sql = "UPDATE Produto SET Nome = @Nome, Fornecedor = @Fornecedor, Categoria = @Categoria, Preco = @Preco, Quantidade = @Quantidade, Descricao = @Descricao WHERE ID = @ID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Nome", produto.Nome);
                command.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
                command.Parameters.AddWithValue("@Categoria", produto.Categoria);
                command.Parameters.AddWithValue("@Preco", produto.Preco);
                command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                command.ExecuteNonQuery();
            }
        }


        public void Deletar(int id) // Método para deletar um produto no banco de dados
        {
            using (SqlConnection connection = Con.ReturnConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"DELETE FROM Produto WHERE ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }


        public SqlCommand GetCmd()
        {
            return Cmd;
        }

        public List<Produto> ListarProdutos()  // Método para listar todos os produtos do banco de dados
        {
            using (SqlConnection connection = Con.ReturnConnection())
            {
                connection.Open(); 

                Cmd.Connection = connection;
                Cmd.CommandText = @"SELECT * FROM Produto";

                List<Produto> produtos = new List<Produto>();
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        int id = (int)rd["ID"];
                        string nome = (string)rd["Nome"];
                        string fornecedor = (string)rd["Fornecedor"];
                        string categoria = (string)rd["Categoria"];
                        string unidade = (string)rd["Unidade"];
                        decimal preco = (decimal)rd["Preco"];
                        int quantidade = (int)rd["Quantidade"];
                        string descricao = (string)rd["Descricao"];
                        produtos.Add(new Produto(id, nome, fornecedor, categoria, unidade, preco, quantidade, descricao));
                    }
                    return produtos;
                }
                catch (Exception ex)
                {
                    // Trate a exceção de alguma forma apropriada, como registrar o erro ou retornar uma lista vazia
                    Console.WriteLine("Erro ao listar produtos: " + ex.Message);
                    return new List<Produto>();
                }
                finally
                {
                    connection.Close(); // Fecha a conexão com o banco de dados
                }
            }
        }


    }
}
