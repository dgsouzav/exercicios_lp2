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
    public partial class CadastroDeUsuario : Form
    {
        private int id;
        public CadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            ltvUsuario.Items.Clear();
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            List<Usuario> usuarios = usuarioDAO.ListarUsuarios();
            if(usuarios.Count > 0)
            {
                foreach(Usuario usuario in usuarios)
                {
                    ListViewItem item = new ListViewItem(usuario.ID.ToString());
                    item.SubItems.Add(usuario.Nome);
                    item.SubItems.Add(usuario.Senha);
                    item.SubItems.Add(usuario.Email);
                    item.SubItems.Add(usuario.Telefone);
                    item.SubItems.Add(usuario.CPF);
                    item.SubItems.Add(usuario.Endereco);
                    item.SubItems.Add(usuario.CEP);
                    item.SubItems.Add(usuario.Cidade);
                    item.SubItems.Add(usuario.Estado);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void ClearFields()
        {
            txbNome.Clear();
            txbSenha.Clear();
            txbEmail.Clear();
            txbTelefone.Clear();
            txbCPF.Clear();
            txbEndereco.Clear();
            txbCEP.Clear(); 
            txbCidade.Clear();
            txbEstado.Clear();
            btnDeletar.Visible = false;

        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();

                try
                {
                    usuarioDAO.Deletar(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ClearFields();
                UpdateListView();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ltvUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ltvUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            int index = ltvUsuario.FocusedItem.Index;
            id = int.Parse(ltvUsuario.Items[index].SubItems[0].Text);
            txbNome.Text = ltvUsuario.Items[index].SubItems[1].Text;
            txbSenha.Text = ltvUsuario.Items[index].SubItems[2].Text;
            txbEmail.Text = ltvUsuario.Items[index].SubItems[3].Text;
            txbTelefone.Text = ltvUsuario.Items[index].SubItems[4].Text;
            txbCPF.Text = ltvUsuario.Items[index].SubItems[5].Text;
            txbEndereco.Text = ltvUsuario.Items[index].SubItems[6].Text;
            txbCEP.Text = ltvUsuario.Items[index].SubItems[7].Text;
            txbCidade.Text = ltvUsuario.Items[index].SubItems[8].Text;
            txbEstado.Text = ltvUsuario.Items[index].SubItems[9].Text;

            btnDeletar.Visible = true;
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
