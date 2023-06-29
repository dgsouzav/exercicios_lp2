using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class FornecedorDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public void Inserir(Fornecedor fornecedor)
        {
            Conexao conexao = new Conexao();
            string sql = "INSERT INTO Fornecedor (Nome, Endereco, CEP, Cidade, Estado, CNPJ, Telefone, Email) VALUES (@Nome, @Endereco, @CEP, @Cidade, @Estado, @CNPJ, @Telefone, @Email)";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
            command.Parameters.AddWithValue("@CEP", fornecedor.CEP);
            command.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
            command.Parameters.AddWithValue("@Estado", fornecedor.Estado);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            command.Parameters.AddWithValue("@Email", fornecedor.Email);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }
        public void Atualizar(Fornecedor fornecedor)
        {
            Conexao conexao = new Conexao();
            string sql = "UPDATE Fornecedor SET Nome = @Nome, Endereco = @Endereco, CEP = @CEP, Cidade = @Cidade, Estado = @Estado, CNPJ = @CNPJ, Telefone = @Telefone, Email = @Email WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
            command.Parameters.AddWithValue("@CEP", fornecedor.CEP);
            command.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
            command.Parameters.AddWithValue("@Estado", fornecedor.Estado);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            command.Parameters.AddWithValue("@Email", fornecedor.Email);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }
        public void Deletar(int id)
        {
            Conexao conexao = new Conexao();
            string sql = "DELETE FROM Fornecedor WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql, conexao.ReturnConnection());
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            conexao.CloseConnection();
        }

    }
}
