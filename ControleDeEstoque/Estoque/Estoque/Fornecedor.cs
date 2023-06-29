using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Fornecedor
    {
        private int ID;
        private string nome;
        private string endereco;
        private string cep;
        private string cidade;
        private string estado;
        private string cnpj;
        private string telefone;
        private string email;


        public Fornecedor(int ID, string nome, string endereco, string cep, string cidade, string estado, string cnpj, string telefone, string email)
        {
            ID = id;
            Nome = nome;
            Endereco = endereco;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
            CNPJ = cnpj;
            Telefone = telefone;
            Email = email;
        }

        public int id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 0)
                    nome = value;
                else
                    throw new Exception("Nome não pode ser vazio");
            }
        }
        public string Endereco
        {
            get { return endereco; }
            set
            {
                if (value.Length > 0)
                    endereco = value;
                else
                    throw new Exception("Endereço não pode ser vazio");
            }
        }
        public string CEP
        {
            get { return cep; }
            set
            {
                if (value.Length > 0)
                    cep = value;
                else
                    throw new Exception("CEP não pode ser vazio");
            }
        }
        public string Cidade
        {
            get { return cidade; }
            set
            {
                if (value.Length > 0)
                    cidade = value;
                else
                    throw new Exception("Cidade não pode ser vazio");
            }
        }
        public string Estado
        {
            get { return estado; }
            set
            {
                if (value.Length > 0)
                    estado = value;
                else
                    throw new Exception("Estado não pode ser vazio");
            }
        }
        public string CNPJ
        {
            get { return cnpj; }
            set
            {
                if (value.Length > 0)
                    cnpj = value;
                else
                    throw new Exception("CNPJ não pode ser vazio");
            }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length > 0)
                    telefone = value;
                else
                    throw new Exception("Telefone não pode ser vazio");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Length > 0)
                    email = value;
                else
                    throw new Exception("Email não pode ser vazio");
            }
        }
    }

}
