namespace Estoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormularioDeLogin = new System.Windows.Forms.GroupBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.FormularioDeLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormularioDeLogin
            // 
            this.FormularioDeLogin.Controls.Add(this.btnCancelar);
            this.FormularioDeLogin.Controls.Add(this.txtSenha);
            this.FormularioDeLogin.Controls.Add(this.txtUsuario);
            this.FormularioDeLogin.Controls.Add(this.btnEntrar);
            this.FormularioDeLogin.Controls.Add(this.lblSenha);
            this.FormularioDeLogin.Controls.Add(this.lblLogin);
            this.FormularioDeLogin.Location = new System.Drawing.Point(12, 12);
            this.FormularioDeLogin.Name = "FormularioDeLogin";
            this.FormularioDeLogin.Size = new System.Drawing.Size(340, 136);
            this.FormularioDeLogin.TabIndex = 5;
            this.FormularioDeLogin.TabStop = false;
            this.FormularioDeLogin.Text = "Formulário de Login";
            this.FormularioDeLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 29);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(6, 68);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(245, 110);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(89, 22);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(328, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 84);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(328, 20);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(150, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 22);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 160);
            this.Controls.Add(this.FormularioDeLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormularioDeLogin.ResumeLayout(false);
            this.FormularioDeLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FormularioDeLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCancelar;
    }
}

