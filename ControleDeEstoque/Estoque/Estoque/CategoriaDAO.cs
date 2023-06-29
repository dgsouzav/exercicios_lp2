using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class CategoriaDAO
    {
        private Conexao Conexao { get; set; }
        private SqlCommand Cmd { get; set; }

        public void Inserir(Categoria categoria)
        {
            Conexao conexao = new Conexao();
            string sql = "INSERT INTO Categoria (Nome) VALUES (@Nome)";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@Nome", categoria.Nome);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }
        private void Atualizar(Categoria categoria)
        {
            Conexao conexao = new Conexao();
            string sql = "UPDATE Categoria SET Nome = @Nome WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@Nome", categoria.Nome);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }
        public void Deletar(int id)
        {
            Conexao conexao = new Conexao();
            string sql = "DELETE FROM Categoria WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }
    }
}
