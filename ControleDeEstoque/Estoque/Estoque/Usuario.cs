using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Estoque
{
    internal class Usuario
    {
        private int id;
        private string nome;
        private string cpf;
        private string endereco;
        private string cep;
        private string cidade;
        private string estado;
        private string telefone;
        private string email;
        private string senha;


        public Usuario(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public Usuario(string nome, string senha, string email, string telefone, string cpf, string endereco, string cep, string cidade, string estado)
        {
            this.nome=nome;
            this.senha=senha;
            this.email=email;
            this.telefone=telefone;
            this.cpf=cpf;
            this.endereco=endereco;
            this.cep=cep;
            this.cidade=cidade;
            this.estado=estado;
        }

        public Usuario(int ID, string nome, string cpf, string endereco, string cep, string cidade, string estado, string telefone, string email, string senha)
        {
            ID = id;
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            Email = email;
            Senha = senha;
        }
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string CPF
        {
            get { return cpf; }
            set
            {
                if (value.Length >= 11)
                {
                    cpf = value;
                }
                else
                {
                    throw new Exception("O CPF deve ter pelo menos 11 caracteres.");
                }
            }
        }   
        public string Endereco
        {
            get { return endereco; }
            set
            {
                if (value.Length <= 50)
                {
                    endereco = value;
                }
                else
                {
                    throw new Exception("O endereço deve ter no máximo 50 caracteres.");
                }
            }
        }
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set
            {
                if (value.Length <= 2)
                {
                    estado = value;
                }
                else
                {
                    throw new Exception("O estado deve ter no máximo 2 caracteres.");
                }
            }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length <= 11)
                {
                    telefone = value;
                }
                else
                {
                    throw new Exception("O telefone deve ter no máximo 11 caracteres.");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Length <= 20)
                {
                    email = value;
                }
                else
                {
                    throw new Exception("O email deve ter no máximo 20 caracteres.");
                }
            }
        }   
        public string Senha
        {
            get { return senha; }
            set
            {
                if (value.Length <= 20)
                {
                    senha = value;
                }
                else
                {
                    throw new Exception("A senha deve ter no máximo 20 caracteres.");
                }
            }
        }   
    }
}
