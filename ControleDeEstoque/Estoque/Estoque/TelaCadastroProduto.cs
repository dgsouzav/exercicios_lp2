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
    public partial class TelaCadastroProduto : Form
    {
        
        public TelaCadastroProduto()
        {
            InitializeComponent();
            //ltvProduto = new ListView();
        }

        private void UpdateListView()
        {
            // Limpa a lista de produtos
            ltvProduto.Items.Clear();

            // Cria uma instância do ProdutoDAO
            ProdutoDAO produtoDAO = new ProdutoDAO();

            // Obtém a lista de produtos do banco de dados
            List<Produto> produtos = produtoDAO.ListarProdutos();


            // Loop para adicionar os produtos na lista
            foreach (Produto produto in produtos)
            {
                // Cria um array de strings para armazenar os dados do produto
                string[] row =
                {
                    produto.ID.ToString(),
                    produto.Nome,
                    produto.Categoria,
                    produto.Preco.ToString(),
                    produto.Quantidade.ToString()
                };

                // Cria um objeto do tipo ListViewItem para armazenar os dados do produto
                ListViewItem lvi = new ListViewItem(row);

                // Adiciona o item na lista de produtos
                ltvProduto.Items.Add(lvi);
            }
        }

        private void ClearFields() // Método para limpar os campos do formulário
        {
            txbNome.Clear();
            txbQtd.Clear();
            txbFornecedor.Clear();
            txbPreco.Clear();
            txbDescricao.Clear();
            txbUnidade.Clear();
            cmbCategoria.SelectedIndex = -1;
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            // Chama o método UpdateListView para preencher a lista de produtos
            UpdateListView();
        }


        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos foram preenchidos
            if (!string.IsNullOrEmpty(txbNome.Text) && !string.IsNullOrEmpty(txbFornecedor.Text) && !string.IsNullOrEmpty(cmbCategoria.Text) && !string.IsNullOrEmpty(txbUnidade.Text)
                && decimal.TryParse(txbPreco.Text, out decimal preco) && int.TryParse(txbQtd.Text, out int Qtd) && !string.IsNullOrEmpty(txbDescricao.Text))
            {
                try
                {
                    // Cria uma instância do Produto com os dados do formulário
                    Produto produto = new Produto(0, txbNome.Text, txbFornecedor.Text, cmbCategoria.Text, txbUnidade.Text, preco, Qtd, txbDescricao.Text);

                    // Cria uma instância do ProdutoDAO
                    ProdutoDAO produtoDAO = new ProdutoDAO();

                    // Chama o método Inserir do ProdutoDAO para adicionar o produto no banco de dados
                    produtoDAO.Inserir(produto);

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Produto cadastrado com sucesso!");

                    // Limpa os campos do formulário
                    ClearFields();

                    // Atualiza a lista de produtos
                    UpdateListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (ltvProduto.SelectedItems.Count > 0)
            {
                // Obtém o ID do produto selecionado
                int id = int.Parse(ltvProduto.SelectedItems[0].Text);

                // Cria uma instância do ProdutoDAO
                ProdutoDAO produtoDAO = new ProdutoDAO();

                try
                {
                    // Chama o método Deletar do ProdutoDAO
                    produtoDAO.Deletar(id);
                    MessageBox.Show("Produto excluído com sucesso!");

                    // Limpa os campos ou atualiza a lista de produtos
                    ClearFields();
                    UpdateListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }



        private void ltvProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
