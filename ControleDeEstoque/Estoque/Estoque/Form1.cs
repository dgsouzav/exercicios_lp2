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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioLogin = new UsuarioDAO();
            Usuario usuario = new Usuario(txtEmail.Text, txtSenha.Text);
            if (usuarioLogin.Login(usuario))
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
        }
    }
}
