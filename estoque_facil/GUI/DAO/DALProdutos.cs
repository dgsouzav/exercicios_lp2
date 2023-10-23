using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProdutos
    {
        private DALConexao conexao;
        public DALProdutos(DALConexao conexao)
        {
            this.conexao=conexao;
        }


    }
}
