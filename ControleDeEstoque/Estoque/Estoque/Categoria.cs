using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Categoria {

        private int ID;
        private string nome;

        public Categoria(int ID, string nome)
        {
            ID = id;
            Nome = nome;
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
    }
}
