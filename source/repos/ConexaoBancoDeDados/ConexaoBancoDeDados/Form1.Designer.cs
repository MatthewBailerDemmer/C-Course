namespace ConexaoBancoDeDados
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
            this.buttonCriarTabela = new System.Windows.Forms.Button();
            this.buttonDeletarTabela = new System.Windows.Forms.Button();
            this.buttonInserirItem = new System.Windows.Forms.Button();
            this.buttonApagarItem = new System.Windows.Forms.Button();
            this.buttonAutalizaItem = new System.Windows.Forms.Button();
            this.buttonPegaItens = new System.Windows.Forms.Button();
            this.buttonVariaveis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCriarTabela
            // 
            this.buttonCriarTabela.Location = new System.Drawing.Point(67, 22);
            this.buttonCriarTabela.Name = "buttonCriarTabela";
            this.buttonCriarTabela.Size = new System.Drawing.Size(81, 36);
            this.buttonCriarTabela.TabIndex = 0;
            this.buttonCriarTabela.Text = "Criar Tabela";
            this.buttonCriarTabela.UseVisualStyleBackColor = true;
            this.buttonCriarTabela.Click += new System.EventHandler(this.buttonCriarTabela_Click);
            // 
            // buttonDeletarTabela
            // 
            this.buttonDeletarTabela.Location = new System.Drawing.Point(67, 78);
            this.buttonDeletarTabela.Name = "buttonDeletarTabela";
            this.buttonDeletarTabela.Size = new System.Drawing.Size(81, 36);
            this.buttonDeletarTabela.TabIndex = 1;
            this.buttonDeletarTabela.Text = "Deletar Tabela";
            this.buttonDeletarTabela.UseVisualStyleBackColor = true;
            this.buttonDeletarTabela.Click += new System.EventHandler(this.buttonDeletarTabela_Click);
            // 
            // buttonInserirItem
            // 
            this.buttonInserirItem.Location = new System.Drawing.Point(67, 134);
            this.buttonInserirItem.Name = "buttonInserirItem";
            this.buttonInserirItem.Size = new System.Drawing.Size(86, 31);
            this.buttonInserirItem.TabIndex = 2;
            this.buttonInserirItem.Text = "Inserir Item";
            this.buttonInserirItem.UseVisualStyleBackColor = true;
            this.buttonInserirItem.Click += new System.EventHandler(this.buttonInserirItem_Click);
            // 
            // buttonApagarItem
            // 
            this.buttonApagarItem.Location = new System.Drawing.Point(67, 183);
            this.buttonApagarItem.Name = "buttonApagarItem";
            this.buttonApagarItem.Size = new System.Drawing.Size(81, 32);
            this.buttonApagarItem.TabIndex = 3;
            this.buttonApagarItem.Text = "Apagar Item";
            this.buttonApagarItem.UseVisualStyleBackColor = true;
            this.buttonApagarItem.Click += new System.EventHandler(this.buttonApagarItem_Click);
            // 
            // buttonAutalizaItem
            // 
            this.buttonAutalizaItem.Location = new System.Drawing.Point(70, 243);
            this.buttonAutalizaItem.Name = "buttonAutalizaItem";
            this.buttonAutalizaItem.Size = new System.Drawing.Size(78, 27);
            this.buttonAutalizaItem.TabIndex = 4;
            this.buttonAutalizaItem.Text = "Atualiza Item";
            this.buttonAutalizaItem.UseVisualStyleBackColor = true;
            this.buttonAutalizaItem.Click += new System.EventHandler(this.buttonAutalizaItem_Click);
            // 
            // buttonPegaItens
            // 
            this.buttonPegaItens.Location = new System.Drawing.Point(71, 301);
            this.buttonPegaItens.Name = "buttonPegaItens";
            this.buttonPegaItens.Size = new System.Drawing.Size(82, 28);
            this.buttonPegaItens.TabIndex = 5;
            this.buttonPegaItens.Text = "Pegar Itens";
            this.buttonPegaItens.UseVisualStyleBackColor = true;
            this.buttonPegaItens.Click += new System.EventHandler(this.buttonPegaItens_Click);
            // 
            // buttonVariaveis
            // 
            this.buttonVariaveis.Location = new System.Drawing.Point(66, 352);
            this.buttonVariaveis.Name = "buttonVariaveis";
            this.buttonVariaveis.Size = new System.Drawing.Size(82, 32);
            this.buttonVariaveis.TabIndex = 6;
            this.buttonVariaveis.Text = "Variaveis";
            this.buttonVariaveis.UseVisualStyleBackColor = true;
            this.buttonVariaveis.Click += new System.EventHandler(this.buttonVariaveis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVariaveis);
            this.Controls.Add(this.buttonPegaItens);
            this.Controls.Add(this.buttonAutalizaItem);
            this.Controls.Add(this.buttonApagarItem);
            this.Controls.Add(this.buttonInserirItem);
            this.Controls.Add(this.buttonDeletarTabela);
            this.Controls.Add(this.buttonCriarTabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCriarTabela;
        private System.Windows.Forms.Button buttonDeletarTabela;
        private System.Windows.Forms.Button buttonInserirItem;
        private System.Windows.Forms.Button buttonApagarItem;
        private System.Windows.Forms.Button buttonAutalizaItem;
        private System.Windows.Forms.Button buttonPegaItens;
        private System.Windows.Forms.Button buttonVariaveis;
    }
}

