namespace MenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.Novo = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Projeto = new System.Windows.Forms.ToolStripMenuItem();
            this.Repositorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arquivo,
            this.Editar,
            this.Exibir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Arquivo
            // 
            this.Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Novo,
            this.Abrir});
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Arquivo.Text = "Arquivo";
            // 
            // Editar
            // 
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(49, 20);
            this.Editar.Text = "Editar";
            // 
            // Exibir
            // 
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(48, 20);
            this.Exibir.Text = "Exibir";
            // 
            // Novo
            // 
            this.Novo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Projeto,
            this.Repositorio});
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(180, 22);
            this.Novo.Text = "Novo";
            // 
            // Abrir
            // 
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(180, 22);
            this.Abrir.Text = "Abrir";
            // 
            // Projeto
            // 
            this.Projeto.Name = "Projeto";
            this.Projeto.Size = new System.Drawing.Size(180, 22);
            this.Projeto.Text = "Projeto";
            // 
            // Repositorio
            // 
            this.Repositorio.Name = "Repositorio";
            this.Repositorio.Size = new System.Drawing.Size(180, 22);
            this.Repositorio.Text = "Repositorio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Novo;
        private System.Windows.Forms.ToolStripMenuItem Projeto;
        private System.Windows.Forms.ToolStripMenuItem Repositorio;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem Editar;
        private System.Windows.Forms.ToolStripMenuItem Exibir;
    }
}

