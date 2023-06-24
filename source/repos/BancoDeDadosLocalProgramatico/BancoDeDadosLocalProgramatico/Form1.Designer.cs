namespace BancoDeDadosLocalProgramatico
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
            this.buttonApagaTabela = new System.Windows.Forms.Button();
            this.buttonAdicionaItem = new System.Windows.Forms.Button();
            this.buttonApagaItem = new System.Windows.Forms.Button();
            this.buttonAtualizaItem = new System.Windows.Forms.Button();
            this.buttonSelectItem1 = new System.Windows.Forms.Button();
            this.buttonVariaveis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCriarTabela
            // 
            this.buttonCriarTabela.Location = new System.Drawing.Point(12, 25);
            this.buttonCriarTabela.Name = "buttonCriarTabela";
            this.buttonCriarTabela.Size = new System.Drawing.Size(122, 28);
            this.buttonCriarTabela.TabIndex = 0;
            this.buttonCriarTabela.Text = "Criar uma tabela";
            this.buttonCriarTabela.UseVisualStyleBackColor = true;
            this.buttonCriarTabela.Click += new System.EventHandler(this.buttonCriarTabela_Click);
            // 
            // buttonApagaTabela
            // 
            this.buttonApagaTabela.Location = new System.Drawing.Point(12, 59);
            this.buttonApagaTabela.Name = "buttonApagaTabela";
            this.buttonApagaTabela.Size = new System.Drawing.Size(122, 30);
            this.buttonApagaTabela.TabIndex = 1;
            this.buttonApagaTabela.Text = "Apagar Tabela";
            this.buttonApagaTabela.UseVisualStyleBackColor = true;
            this.buttonApagaTabela.Click += new System.EventHandler(this.buttonApagaTabela_Click);
            // 
            // buttonAdicionaItem
            // 
            this.buttonAdicionaItem.Location = new System.Drawing.Point(12, 95);
            this.buttonAdicionaItem.Name = "buttonAdicionaItem";
            this.buttonAdicionaItem.Size = new System.Drawing.Size(122, 28);
            this.buttonAdicionaItem.TabIndex = 2;
            this.buttonAdicionaItem.Text = "Adicionar Item";
            this.buttonAdicionaItem.UseVisualStyleBackColor = true;
            this.buttonAdicionaItem.Click += new System.EventHandler(this.buttonAdicionaItem_Click);
            // 
            // buttonApagaItem
            // 
            this.buttonApagaItem.Location = new System.Drawing.Point(12, 129);
            this.buttonApagaItem.Name = "buttonApagaItem";
            this.buttonApagaItem.Size = new System.Drawing.Size(122, 34);
            this.buttonApagaItem.TabIndex = 3;
            this.buttonApagaItem.Text = "Apagar Item";
            this.buttonApagaItem.UseVisualStyleBackColor = true;
            this.buttonApagaItem.Click += new System.EventHandler(this.buttonApagaItem_Click);
            // 
            // buttonAtualizaItem
            // 
            this.buttonAtualizaItem.Location = new System.Drawing.Point(12, 169);
            this.buttonAtualizaItem.Name = "buttonAtualizaItem";
            this.buttonAtualizaItem.Size = new System.Drawing.Size(122, 31);
            this.buttonAtualizaItem.TabIndex = 4;
            this.buttonAtualizaItem.Text = "Atualizar Item";
            this.buttonAtualizaItem.UseVisualStyleBackColor = true;
            this.buttonAtualizaItem.Click += new System.EventHandler(this.buttonAtualizaItem_Click);
            // 
            // buttonSelectItem1
            // 
            this.buttonSelectItem1.Location = new System.Drawing.Point(12, 215);
            this.buttonSelectItem1.Name = "buttonSelectItem1";
            this.buttonSelectItem1.Size = new System.Drawing.Size(122, 30);
            this.buttonSelectItem1.TabIndex = 5;
            this.buttonSelectItem1.Text = "Selecionar Item 1";
            this.buttonSelectItem1.UseVisualStyleBackColor = true;
            this.buttonSelectItem1.Click += new System.EventHandler(this.buttonSelectItem1_Click);
            // 
            // buttonVariaveis
            // 
            this.buttonVariaveis.Location = new System.Drawing.Point(12, 260);
            this.buttonVariaveis.Name = "buttonVariaveis";
            this.buttonVariaveis.Size = new System.Drawing.Size(122, 25);
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
            this.Controls.Add(this.buttonSelectItem1);
            this.Controls.Add(this.buttonAtualizaItem);
            this.Controls.Add(this.buttonApagaItem);
            this.Controls.Add(this.buttonAdicionaItem);
            this.Controls.Add(this.buttonApagaTabela);
            this.Controls.Add(this.buttonCriarTabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCriarTabela;
        private System.Windows.Forms.Button buttonApagaTabela;
        private System.Windows.Forms.Button buttonAdicionaItem;
        private System.Windows.Forms.Button buttonApagaItem;
        private System.Windows.Forms.Button buttonAtualizaItem;
        private System.Windows.Forms.Button buttonSelectItem1;
        private System.Windows.Forms.Button buttonVariaveis;
    }
}

