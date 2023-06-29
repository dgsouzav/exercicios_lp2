using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class ProdutoDAO
    {
        public void Inserir(Produto produto)
        {
            Conexao conexao = new Conexao();
            string sql = "INSERT INTO Produto (Nome, Preco, FornecedorID, CategoriaID, Quantidade, Descricao) VALUES (@Nome, @Preco, @FornecedorID, @CategoriaID, @Quantidade, @Descricao)";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@Nome", produto.Nome);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            command.Parameters.AddWithValue("@FornecedorID", produto.FornecedorID);
            command.Parameters.AddWithValue("@CategoriaID", produto.CategoriaID);
            command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }

        public void Atualizar(Produto produto)
        {
            Conexao conexao = new Conexao();
            string sql = "UPDATE Produto SET Nome = @Nome, Preco = @Preco, FornecedorID = @FornecedorID, CategoriaID = @CategoriaID, Quantidade = @Quantidade, Descricao = @Descricao WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@ID", produto.ID);
            command.Parameters.AddWithValue("@Nome", produto.Nome);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            command.Parameters.AddWithValue("@FornecedorID", produto.FornecedorID);
            command.Parameters.AddWithValue("@CategoriaID", produto.CategoriaID);
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

        public List<Produto> Listar()
        {
            Conexao conexao = new Conexao();
            string sql = "SELECT * FROM Produto";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            SqlDataReader reader = command.ExecuteReader();
            List<Produto> produtos = new List<Produto>();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader)
                }
        }
    }
}
