﻿using System;

namespace Estoque
{
    internal class Produto
    {
        public int ID;
        public string nome;
        public decimal preco;
        public int qtd;
        public string descricao;

        public Produto(int ID, string nome, decimal preco, int quantidade, string descricao)
        {
            ID = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Descricao = descricao;
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
