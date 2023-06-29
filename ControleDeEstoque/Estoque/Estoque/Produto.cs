using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produto
    {
        internal class Fornecedor
        {
            public int ID 
            public string Nome 
            public string Endereco 
            public string CNPJ 
            public string Telefone 
            public string Email 

            public Fornecedor(int id, string nome, string endereco, string cnpj, string telefone, string email)
            {
                ID = id;
                Nome = nome;
                Endereco = endereco;
                CNPJ = cnpj;
                Telefone = telefone;
                Email = email;
            }
        }

        internal class Categoria
        {
            public int ID 
            public string Nome 

            public Categoria(int id, string nome)
            {
                ID = id;
                Nome = nome;
            }
        }

        internal class Produto
        {
            public int ID 
            public string Nome 
            public decimal Preco 
            public int FornecedorID 
            public int CategoriaID 
            public int Quantidade 
            public string Descricao 

            public Produto(string nome, decimal preco, int fornecedorID, int categoriaID, int quantidade, string descricao)
            {
                Nome = nome;
                Preco = preco;
                FornecedorID = fornecedorID;
                CategoriaID = categoriaID;
                Quantidade = quantidade;
                Descricao = descricao;
            }

            public Produto(int ID, string nome, decimal preco, int fornecedorID, int categoriaID, int quantidade, string descricao)
            {
                ID = id;
            }
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Nome
            {
                get { return nome; }
                set
                {
                    if(value.Length > 0)
                        nome = value;
                    else
                        throw new Exception("Nome não pode ser vazio")
                }
            }
            public decimal Preco
            {
                get { return preco; }
                set
                {
                    if(value > 0)
                        preco = value;
                    else
                        throw new Exception("Preço não pode ser negativo")
                }
            }
            public int FornecedorID
            {
                get { return fornecedorID; }
                set { fornecedorID = value; }
            }
            public int CategoriaID
            {
                get { return categoriaID; }
                set { categoriaID = value; }
            }
            public int Quantidade
            {
                get { return quantidade; }
                set
                {
                    if(value > 0)
                        quantidade = value;
                    else
                        throw new Exception("Quantidade não pode ser negativa")
                }
            }
            public string Descricao
            {
                get { return descricao; }
                set
                {
                    if(value.Length > 0)
                        descricao = value;
                    else
                        throw new Exception("Descrição não pode ser vazia")
                }
            }
        }
    }
}
