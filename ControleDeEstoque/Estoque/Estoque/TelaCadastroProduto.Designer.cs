namespace Estoque
{
    partial class TelaCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarAoMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txbUnidade = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txbFornecedor = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txbQtd = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.ltvProduto = new System.Windows.Forms.ListView();
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarAoMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            this.voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            this.voltarAoMenuToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.voltarAoMenuToolStripMenuItem.Text = "Voltar ao Menu";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(685, 156);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 57);
            this.btnLimpar.TabIndex = 45;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(237, 112);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 40;
            this.lblPreco.Text = "Preço";
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(240, 126);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(222, 20);
            this.txbPreco.TabIndex = 39;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(12, 110);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(47, 13);
            this.lblUnidade.TabIndex = 38;
            this.lblUnidade.Text = "Unidade";
            // 
            // txbUnidade
            // 
            this.txbUnidade.Location = new System.Drawing.Point(12, 126);
            this.txbUnidade.Name = "txbUnidade";
            this.txbUnidade.Size = new System.Drawing.Size(222, 20);
            this.txbUnidade.TabIndex = 37;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(237, 75);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 36;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(12, 73);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 34;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txbFornecedor
            // 
            this.txbFornecedor.Location = new System.Drawing.Point(12, 89);
            this.txbFornecedor.Name = "txbFornecedor";
            this.txbFornecedor.Size = new System.Drawing.Size(222, 20);
            this.txbFornecedor.TabIndex = 33;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(240, 148);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 32;
            this.lblDescricao.Text = "Descrição";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(240, 165);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(222, 20);
            this.txbDescricao.TabIndex = 31;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(12, 149);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(62, 13);
            this.lblQtd.TabIndex = 30;
            this.lblQtd.Text = "Quantidade";
            // 
            // txbQtd
            // 
            this.txbQtd.Location = new System.Drawing.Point(12, 165);
            this.txbQtd.Name = "txbQtd";
            this.txbQtd.Size = new System.Drawing.Size(222, 20);
            this.txbQtd.TabIndex = 29;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(685, 95);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(103, 54);
            this.btnDeletar.TabIndex = 28;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(685, 29);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(103, 60);
            this.btnCadastro.TabIndex = 27;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // ltvProduto
            // 
            this.ltvProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNome,
            this.clhFornecedor,
            this.clhCategoria,
            this.clhUnidade,
            this.clhQtd});
            this.ltvProduto.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltvProduto.HideSelection = false;
            this.ltvProduto.Location = new System.Drawing.Point(12, 229);
            this.ltvProduto.Name = "ltvProduto";
            this.ltvProduto.Size = new System.Drawing.Size(776, 209);
            this.ltvProduto.TabIndex = 26;
            this.ltvProduto.UseCompatibleStateImageBehavior = false;
            this.ltvProduto.View = System.Windows.Forms.View.Details;
            this.ltvProduto.SelectedIndexChanged += new System.EventHandler(this.ltvProduto_SelectedIndexChanged);
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            // 
            // clhFornecedor
            // 
            this.clhFornecedor.Text = "Fornecedor";
            // 
            // clhCategoria
            // 
            this.clhCategoria.Text = "Categoria";
            // 
            // clhUnidade
            // 
            this.clhUnidade.Text = "Unidade";
            // 
            // clhQtd
            // 
            this.clhQtd.Text = "Quantidade";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(12, 50);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(450, 20);
            this.txbNome.TabIndex = 25;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(243, 89);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(219, 21);
            this.cmbCategoria.TabIndex = 46;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // TelaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.txbUnidade);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txbFornecedor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txbQtd);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.ltvProduto);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaCadastroProduto";
            this.Load += new System.EventHandler(this.TelaCadastroProduto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txbUnidade;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txbFornecedor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txbQtd;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.ListView ltvProduto;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhFornecedor;
        private System.Windows.Forms.ColumnHeader clhCategoria;
        private System.Windows.Forms.ColumnHeader clhUnidade;
        private System.Windows.Forms.ColumnHeader clhQtd;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}