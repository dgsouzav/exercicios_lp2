﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class UsuarioDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public UsuarioDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Usuario VALUES (@nome, @cpf, @endereco, @cep, @cidade, @estado, @telefone, @email, @senha)";
            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
            Cmd.Parameters.AddWithValue("@endereco", usuario.Endereco);
            Cmd.Parameters.AddWithValue("@cep", usuario.CEP);
            Cmd.Parameters.AddWithValue("@cidade", usuario.Cidade);
            Cmd.Parameters.AddWithValue("@estado", usuario.Estado);
            Cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@email", usuario.Email);
            Cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro ao inserir usuário: " + e.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<Usuario> ListarUsuarios()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM Usuario";

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    int id = (int)rd["id"];
                    string nome = (string)rd["Nome"];
                    string email = (string)rd["Email"];
                    string senha = (string)rd["Senha"];
                    string cpf = (string)rd["CPF"];
                    string endereco = (string)rd["Endereco"];
                    string cep = (string)rd["CEP"];
                    string cidade = (string)rd["Cidade"];
                    string estado = (string)rd["Estado"];
                    string telefone = (string)rd["Telefone"];

                    Usuario usuario = new Usuario(id, nome, cpf, endereco, cep, cidade, estado, telefone, email, senha);
                    usuarios.Add(usuario);
                }
                rd.Close();
            }
            catch
            {
                throw new Exception("Erro ao listar usuários.");
            }
            finally
            {
                Con.CloseConnection();
            }
            return usuarios;
        }


        public void Atualizar(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuario SET Nome = @nome, 
                                CPF = @cpf, Endereco = @endereco, 
                                CEP = @cep, Cidade = @cidade, 
                                Estado = @estado, Telefone = @telefone, Email = @email";
            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
            Cmd.Parameters.AddWithValue("@endereco", usuario.Endereco);
            Cmd.Parameters.AddWithValue("@cep", usuario.CEP);
            Cmd.Parameters.AddWithValue("@cidade", usuario.Cidade);
            Cmd.Parameters.AddWithValue("@estado", usuario.Estado);
            Cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro ao atualizar usuário: " + e.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Deletar(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Usuario WHERE ID = @id";
            Cmd.Parameters.AddWithValue("@id", id);
            
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro ao deletar usuário: " + e.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        internal bool Login(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM Usuario WHERE Email = @email";
            Cmd.Parameters.AddWithValue("@email", usuario.Email);
                
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                if (rd.Read())
                {
                    string senha = (string)rd["Senha"];
                    if (senha.Equals(usuario.Senha))
                    {
                        return true;
                    }
                }
                rd.Close();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro ao fazer login: " + e.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return false;   
        }
    }
}
