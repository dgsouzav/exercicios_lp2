using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
        

        private void cadastroUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //abrir tela de cadastro de usuário
            CadastroUsuario telaCadastroUsuario = new CadastroUsuario();
            telaCadastroUsuario.ShowDialog();
        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir tela de cadastro de produtos
            TelaCadastroProduto telaCadastroProduto = new TelaCadastroProduto();
            telaCadastroProduto.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
