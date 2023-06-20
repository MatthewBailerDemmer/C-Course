namespace ServidorCliente
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
            this.buttonEnviaString = new System.Windows.Forms.Button();
            this.buttonPegaString = new System.Windows.Forms.Button();
            this.textEnviaString = new System.Windows.Forms.TextBox();
            this.textPegaString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnviaString
            // 
            this.buttonEnviaString.Location = new System.Drawing.Point(38, 129);
            this.buttonEnviaString.Name = "buttonEnviaString";
            this.buttonEnviaString.Size = new System.Drawing.Size(318, 167);
            this.buttonEnviaString.TabIndex = 0;
            this.buttonEnviaString.Text = "Enviar String";
            this.buttonEnviaString.UseVisualStyleBackColor = true;
            this.buttonEnviaString.Click += new System.EventHandler(this.buttonEnviaString_Click);
            // 
            // buttonPegaString
            // 
            this.buttonPegaString.Location = new System.Drawing.Point(460, 129);
            this.buttonPegaString.Name = "buttonPegaString";
            this.buttonPegaString.Size = new System.Drawing.Size(317, 167);
            this.buttonPegaString.TabIndex = 1;
            this.buttonPegaString.Text = "Pega String";
            this.buttonPegaString.UseVisualStyleBackColor = true;
            this.buttonPegaString.Click += new System.EventHandler(this.button2_Click);
            // 
            // textEnviaString
            // 
            this.textEnviaString.Location = new System.Drawing.Point(38, 103);
            this.textEnviaString.Name = "textEnviaString";
            this.textEnviaString.Size = new System.Drawing.Size(318, 20);
            this.textEnviaString.TabIndex = 2;
            // 
            // textPegaString
            // 
            this.textPegaString.Location = new System.Drawing.Point(460, 103);
            this.textPegaString.Name = "textPegaString";
            this.textPegaString.Size = new System.Drawing.Size(317, 20);
            this.textPegaString.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPegaString);
            this.Controls.Add(this.textEnviaString);
            this.Controls.Add(this.buttonPegaString);
            this.Controls.Add(this.buttonEnviaString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnviaString;
        private System.Windows.Forms.Button buttonPegaString;
        private System.Windows.Forms.TextBox textEnviaString;
        private System.Windows.Forms.TextBox textPegaString;
    }
}

