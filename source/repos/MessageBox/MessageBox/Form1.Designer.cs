namespace MessageBox
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
            this.botaoMessageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoMessageBox
            // 
            this.botaoMessageBox.Location = new System.Drawing.Point(23, 30);
            this.botaoMessageBox.Name = "botaoMessageBox";
            this.botaoMessageBox.Size = new System.Drawing.Size(440, 402);
            this.botaoMessageBox.TabIndex = 0;
            this.botaoMessageBox.Text = "Clique aqui para acessar um MessageBox";
            this.botaoMessageBox.UseVisualStyleBackColor = true;
            this.botaoMessageBox.Click += new System.EventHandler(this.botaoMessageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoMessageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoMessageBox;
    }
}

