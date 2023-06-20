namespace MandandoEmails
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
            this.botaoEnviaEmail = new System.Windows.Forms.Button();
            this.botaoEnviaAnexo = new System.Windows.Forms.Button();
            this.botaoEnviaImagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoEnviaEmail
            // 
            this.botaoEnviaEmail.Location = new System.Drawing.Point(106, 116);
            this.botaoEnviaEmail.Name = "botaoEnviaEmail";
            this.botaoEnviaEmail.Size = new System.Drawing.Size(166, 143);
            this.botaoEnviaEmail.TabIndex = 0;
            this.botaoEnviaEmail.Text = "Enviar Email";
            this.botaoEnviaEmail.UseVisualStyleBackColor = true;
            this.botaoEnviaEmail.Click += new System.EventHandler(this.botaoEnviaEmail_Click);
            // 
            // botaoEnviaAnexo
            // 
            this.botaoEnviaAnexo.Location = new System.Drawing.Point(322, 120);
            this.botaoEnviaAnexo.Name = "botaoEnviaAnexo";
            this.botaoEnviaAnexo.Size = new System.Drawing.Size(170, 134);
            this.botaoEnviaAnexo.TabIndex = 1;
            this.botaoEnviaAnexo.Text = "Enviar Com Anexo";
            this.botaoEnviaAnexo.UseVisualStyleBackColor = true;
            this.botaoEnviaAnexo.Click += new System.EventHandler(this.botaoEnviaAnexo_Click);
            // 
            // botaoEnviaImagem
            // 
            this.botaoEnviaImagem.Location = new System.Drawing.Point(583, 116);
            this.botaoEnviaImagem.Name = "botaoEnviaImagem";
            this.botaoEnviaImagem.Size = new System.Drawing.Size(144, 138);
            this.botaoEnviaImagem.TabIndex = 2;
            this.botaoEnviaImagem.Text = "Enviar Email com Imagem";
            this.botaoEnviaImagem.UseVisualStyleBackColor = true;
            this.botaoEnviaImagem.Click += new System.EventHandler(this.botaoEnviaImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoEnviaImagem);
            this.Controls.Add(this.botaoEnviaAnexo);
            this.Controls.Add(this.botaoEnviaEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoEnviaEmail;
        private System.Windows.Forms.Button botaoEnviaAnexo;
        private System.Windows.Forms.Button botaoEnviaImagem;
    }
}

