namespace TextBoxeReadTextBox
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
            this.meuTextBox = new System.Windows.Forms.TextBox();
            this.meuRichTextBox = new System.Windows.Forms.RichTextBox();
            this.botaoInverte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meuTextBox
            // 
            this.meuTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meuTextBox.Location = new System.Drawing.Point(72, 72);
            this.meuTextBox.Name = "meuTextBox";
            this.meuTextBox.Size = new System.Drawing.Size(424, 22);
            this.meuTextBox.TabIndex = 0;
            // 
            // meuRichTextBox
            // 
            this.meuRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meuRichTextBox.Location = new System.Drawing.Point(72, 100);
            this.meuRichTextBox.Name = "meuRichTextBox";
            this.meuRichTextBox.Size = new System.Drawing.Size(424, 245);
            this.meuRichTextBox.TabIndex = 1;
            this.meuRichTextBox.Text = "";
            // 
            // botaoInverte
            // 
            this.botaoInverte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoInverte.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoInverte.Location = new System.Drawing.Point(12, 351);
            this.botaoInverte.Name = "botaoInverte";
            this.botaoInverte.Size = new System.Drawing.Size(520, 73);
            this.botaoInverte.TabIndex = 2;
            this.botaoInverte.Text = "Clique aqui para inverter";
            this.botaoInverte.UseVisualStyleBackColor = true;
            this.botaoInverte.Click += new System.EventHandler(this.botaoInverte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoInverte);
            this.Controls.Add(this.meuRichTextBox);
            this.Controls.Add(this.meuTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox meuTextBox;
        private System.Windows.Forms.RichTextBox meuRichTextBox;
        private System.Windows.Forms.Button botaoInverte;
    }
}

