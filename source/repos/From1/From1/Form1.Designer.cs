namespace From1
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
            this.meuBotao = new System.Windows.Forms.Button();
            this.minhaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // meuBotao
            // 
            this.meuBotao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.meuBotao.BackColor = System.Drawing.SystemColors.HotTrack;
            this.meuBotao.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meuBotao.Location = new System.Drawing.Point(136, 136);
            this.meuBotao.Name = "meuBotao";
            this.meuBotao.Size = new System.Drawing.Size(336, 145);
            this.meuBotao.TabIndex = 0;
            this.meuBotao.Text = "Meu Primeiro Botao";
            this.meuBotao.UseVisualStyleBackColor = false;
            this.meuBotao.Click += new System.EventHandler(this.button1_Click);
            this.meuBotao.MouseEnter += new System.EventHandler(this.meuBotao_MouseEnter);
            this.meuBotao.MouseLeave += new System.EventHandler(this.meuBotao_MouseLeave);
            // 
            // minhaLabel
            // 
            this.minhaLabel.AutoSize = true;
            this.minhaLabel.Font = new System.Drawing.Font("Sitka Subheading", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minhaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.minhaLabel.Location = new System.Drawing.Point(104, 37);
            this.minhaLabel.Name = "minhaLabel";
            this.minhaLabel.Size = new System.Drawing.Size(611, 87);
            this.minhaLabel.TabIndex = 1;
            this.minhaLabel.Text = "Minha Primeira Lablel";
            this.minhaLabel.Click += new System.EventHandler(this.minaLabel_Click);
            this.minhaLabel.DoubleClick += new System.EventHandler(this.minaLabel_DoubleClick);
            this.minhaLabel.MouseEnter += new System.EventHandler(this.minaLabel_MouseEnter);
            this.minhaLabel.MouseLeave += new System.EventHandler(this.minaLabel_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minhaLabel);
            this.Controls.Add(this.meuBotao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button meuBotao;
        private System.Windows.Forms.Label minhaLabel;
    }
}

