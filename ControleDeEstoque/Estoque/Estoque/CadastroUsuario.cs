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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()  // Construtor
        {
            InitializeComponent();
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e) // Botão voltar ao menu
        {
            this.Close();
        }

        private void ClearFields() // Limpa os campos
        {
            txbNome.Clear();
            txbEndereco.Clear();
            txbCEP.Clear();
            txbCidade.Clear();
            txbEstado.Clear();
            txbTelefone.Clear();
            txbCPF.Clear();
            txbEmail.Clear();
            txbSenha.Clear();
        }

        private void btnCadastro_Click(object sender, EventArgs e) // Botão cadastrar
        {
            try
            {
                Usuario usuario = new Usuario(txbNome.Text, txbSenha.Text,txbEmail.Text,txbTelefone.Text,txbCPF.Text,txbEndereco.Text,txbCEP.Text,txbCidade.Text,txbEstado.Text);
                usuario.Nome = txbNome.Text;
                usuario.CPF = txbCPF.Text;
                usuario.Endereco = txbEndereco.Text;
                usuario.CEP = txbCEP.Text;
                usuario.Cidade = txbCidade.Text;
                usuario.Estado = txbEstado.Text;
                usuario.Telefone = txbTelefone.Text;
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;

                UsuarioDAO usuarioDAO = new UsuarioDAO(); // 

                usuarioDAO.Inserir(usuario); // 

                ClearFields();

                UpdateListView(); // 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ltvUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListView() // atualiza a lista de usuários
        {
            ltvUsuario.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            List<Usuario> usuarios = usuarioDAO.ListarUsuarios();

            foreach (Usuario usuario in usuarios)
            {
                string[] row =
                {
                    usuario.Nome,
                    usuario.CPF,
                    usuario.Endereco,
                    usuario.CEP,
                    usuario.Cidade,
                    usuario.Estado,
                    usuario.Telefone,
                    usuario.Email
                };

                ListViewItem lvi = new ListViewItem(row);

                ltvUsuario.Items.Add(lvi);
            }
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
