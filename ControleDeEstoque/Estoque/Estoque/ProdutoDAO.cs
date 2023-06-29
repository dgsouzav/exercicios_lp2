using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class ProdutoDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public void Inserir(Produto produto)
        {
            Conexao conexao = new Conexao();
            string sql = "INSERT INTO Produto (Nome, Preco, Quantidade, Descricao) VALUES (@Nome, @Preco, @FornecedorID, @CategoriaID, @Quantidade, @Descricao)";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@Nome", produto.Nome);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }

        public void Atualizar(Produto produto)
        {
            Conexao conexao = new Conexao();
            string sql = "UPDATE Produto SET Nome = @Nome, Preco = @Preco, Quantidade = @Quantidade, Descricao = @Descricao WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@Nome", produto.Nome);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }

        public void Deletar(int id)
        {
            Conexao conexao = new Conexao();
            string sql = "DELETE FROM Produto WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }

        public List<Produto> ListarProdutos()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM Produto";

            List<Produto> produtos = new List<Produto>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    int id = (int)rd["ID"];
                    string nome = (string)rd["Nome"];
                    decimal preco = (decimal)rd["Preco"];
                    int quantidade = (int)rd["Quantidade"];
                    string descricao = (string)rd["Descricao"];
                    produtos.Add(new Produto(id, nome, preco, quantidade, descricao));
                }
                return produtos;
            }
            catch
            {
                throw new Exception("Erro ao listar produtos");
            }
            finally
            {
                Con.CloseConnection();
            }
        }
    }
}
