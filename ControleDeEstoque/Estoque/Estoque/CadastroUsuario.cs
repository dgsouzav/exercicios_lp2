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
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // voltar a TelaPrincipal
            this.Close();
        }

        private void ClearFields()
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

        private void btnCadastro_Click(object sender, EventArgs e)
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

                // Cria uma instância do UsuarioDAO
                UsuarioDAO usuarioDAO = new UsuarioDAO();

                // Chama o método Inserir passando o objeto usuario
                usuarioDAO.Inserir(usuario);

                // Limpa os campos após a inserção
                ClearFields();

                // Atualiza a ListView com os dados atualizados do banco de dados
                UpdateListView();
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

        private void UpdateListView()
        {
            // Limpa a lista de usuários
            ltvUsuario.Items.Clear();

            // Cria uma instância do UsuarioDAO
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            // Obtém a lista de usuários do banco de dados
            List<Usuario> usuarios = usuarioDAO.ListarUsuarios();

            // Loop para adicionar os usuários na lista
            foreach (Usuario usuario in usuarios)
            {
                // Cria um array de strings para armazenar os dados do usuário
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

                // Cria um objeto do tipo ListViewItem para armazenar os dados do usuário
                ListViewItem lvi = new ListViewItem(row);

                // Adiciona o item na lista de usuários
                ltvUsuario.Items.Add(lvi);
            }
        }

    }
}
