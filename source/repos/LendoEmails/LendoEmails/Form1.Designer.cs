namespace LendoEmails
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
            this.buttonLerEmail = new System.Windows.Forms.Button();
            this.buttonApagaEmail = new System.Windows.Forms.Button();
            this.buttonApagaTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLerEmail
            // 
            this.buttonLerEmail.Location = new System.Drawing.Point(74, 84);
            this.buttonLerEmail.Name = "buttonLerEmail";
            this.buttonLerEmail.Size = new System.Drawing.Size(154, 253);
            this.buttonLerEmail.TabIndex = 0;
            this.buttonLerEmail.Text = "Ler Ultmo Email";
            this.buttonLerEmail.UseVisualStyleBackColor = true;
            this.buttonLerEmail.Click += new System.EventHandler(this.buttonLerEmail_Click);
            // 
            // buttonApagaEmail
            // 
            this.buttonApagaEmail.Location = new System.Drawing.Point(335, 84);
            this.buttonApagaEmail.Name = "buttonApagaEmail";
            this.buttonApagaEmail.Size = new System.Drawing.Size(123, 253);
            this.buttonApagaEmail.TabIndex = 1;
            this.buttonApagaEmail.Text = "Apagar ultimo email";
            this.buttonApagaEmail.UseVisualStyleBackColor = true;
            this.buttonApagaEmail.Click += new System.EventHandler(this.buttonApagaEmail_Click);
            // 
            // buttonApagaTodos
            // 
            this.buttonApagaTodos.Location = new System.Drawing.Point(572, 84);
            this.buttonApagaTodos.Name = "buttonApagaTodos";
            this.buttonApagaTodos.Size = new System.Drawing.Size(118, 253);
            this.buttonApagaTodos.TabIndex = 2;
            this.buttonApagaTodos.Text = "Apagar todos os emails";
            this.buttonApagaTodos.UseVisualStyleBackColor = true;
            this.buttonApagaTodos.Click += new System.EventHandler(this.buttonApagaTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApagaTodos);
            this.Controls.Add(this.buttonApagaEmail);
            this.Controls.Add(this.buttonLerEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLerEmail;
        private System.Windows.Forms.Button buttonApagaEmail;
        private System.Windows.Forms.Button buttonApagaTodos;
    }
}

