using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    // codigo reaproveitado de uma aula
    internal class Conexao
    {
        public SqlConnection con;
        private readonly string DataBase = "ControleDeEstoqueBDD";
        string stringConnection;

        public Conexao()
        {
            stringConnection = @"Data Source=" + Environment.MachineName +
                @"; Initial Catalog=" + DataBase + ";Integrated Security=True";

            con = new SqlConnection(stringConnection);

        }

        public void AbrirConexao()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        
        public void CloseConnection()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
