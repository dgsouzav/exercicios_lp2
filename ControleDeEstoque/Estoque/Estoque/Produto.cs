using System;

namespace Estoque
{
    internal class Produto // Classe Produto
    {
        private int id;  
        public string nome;
        public string fornecedor;
        public string categoria;
        public string unidade;
        public decimal preco;
        public int qtd;
        public string descricao;

        public Produto(int id, string nome, string fornecedor, string categoria, 
            string unidade, decimal preco, int quantidade, string descricao) // Construtor
        {
            this.id = id;  
            Nome = nome;
            Fornecedor = fornecedor;
            Categoria = categoria;
            Unidade = unidade;
            Preco = preco;
            Quantidade = quantidade;
            Descricao = descricao;
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
                if (!string.IsNullOrEmpty(value))
                    nome = value;
                else
                    throw new Exception("Nome não pode ser vazio");
            }
        }

        public string Fornecedor
        {
            get { return fornecedor; }
            set
            {
                if (value.Length > 0)
                    fornecedor = value;
                else
                    throw new Exception("Fornecedor não pode ser vazio");
            }
        }

        public string Categoria
        {
            get { return categoria; }
            set
            {
                if (value.Length > 0)
                    categoria = value;
                else
                    throw new Exception("Categoria não pode ser vazia");
            }
        }

        public string Unidade
        {
            get { return unidade; }
            set
            {
                if (value.Length > 0)
                    unidade = value;
                else
                    throw new Exception("Unidade não pode ser vazia");
            }
        }
        
        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                    preco = value;
                else
                    throw new Exception("Preço não pode ser negativo");
            }
        }
        
        public int Quantidade
        {
            get { return qtd; }
            set
            {
                if (value > 0)
                    qtd = value;
                else
                    throw new Exception("Quantidade não pode ser negativa");
            }
        }
        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (value.Length > 0)
                    descricao = value;
                else
                    throw new Exception("Descrição não pode ser vazia");
            }
        }
    }
}
