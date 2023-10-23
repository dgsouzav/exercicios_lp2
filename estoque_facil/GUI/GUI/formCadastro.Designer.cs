namespace GUI
{
    partial class formCadastro
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
            panelDados=new Panel();
            panelButtons=new Panel();
            btnInserir=new Button();
            btnLocalizar=new Button();
            btnAlterar=new Button();
            btnExcluir=new Button();
            btnSalvar=new Button();
            btnCancelar=new Button();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
            panelDados.Location=new Point(12, 12);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(760, 420);
            panelDados.TabIndex=1;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnCancelar);
            panelButtons.Controls.Add(btnSalvar);
            panelButtons.Controls.Add(btnExcluir);
            panelButtons.Controls.Add(btnAlterar);
            panelButtons.Controls.Add(btnLocalizar);
            panelButtons.Controls.Add(btnInserir);
            panelButtons.Location=new Point(12, 438);
            panelButtons.Name="panelButtons";
            panelButtons.Size=new Size(760, 111);
            panelButtons.TabIndex=2;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(32, 17);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 80);
            btnInserir.TabIndex=0;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(149, 17);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 80);
            btnLocalizar.TabIndex=1;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(266, 17);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 80);
            btnAlterar.TabIndex=2;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(383, 17);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 80);
            btnExcluir.TabIndex=3;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(500, 17);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 80);
            btnSalvar.TabIndex=4;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(617, 17);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 80);
            btnCancelar.TabIndex=5;
            btnCancelar.Text="CANCELAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // formCadastro
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(784, 561);
            Controls.Add(panelButtons);
            Controls.Add(panelDados);
            Name="formCadastro";
            Text="Cadastro";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelDados;
        private Panel panelButtons;
        private Button btnInserir;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnLocalizar;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}