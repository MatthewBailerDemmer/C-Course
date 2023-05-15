namespace MaskedTextBox
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
            this.maskedTextBoxNumeros = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLetras = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPlacaDeCarro = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHora = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDecimais = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.botaoVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxNumeros
            // 
            this.maskedTextBoxNumeros.Location = new System.Drawing.Point(12, 12);
            this.maskedTextBoxNumeros.Name = "maskedTextBoxNumeros";
            this.maskedTextBoxNumeros.Size = new System.Drawing.Size(329, 22);
            this.maskedTextBoxNumeros.TabIndex = 0;
            // 
            // maskedTextBoxLetras
            // 
            this.maskedTextBoxLetras.Location = new System.Drawing.Point(12, 51);
            this.maskedTextBoxLetras.Name = "maskedTextBoxLetras";
            this.maskedTextBoxLetras.Size = new System.Drawing.Size(329, 22);
            this.maskedTextBoxLetras.TabIndex = 1;
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(12, 99);
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(329, 22);
            this.maskedTextBoxData.TabIndex = 2;
            // 
            // maskedTextBoxPlacaDeCarro
            // 
            this.maskedTextBoxPlacaDeCarro.Location = new System.Drawing.Point(12, 155);
            this.maskedTextBoxPlacaDeCarro.Name = "maskedTextBoxPlacaDeCarro";
            this.maskedTextBoxPlacaDeCarro.Size = new System.Drawing.Size(329, 22);
            this.maskedTextBoxPlacaDeCarro.TabIndex = 3;
            // 
            // maskedTextBoxHora
            // 
            this.maskedTextBoxHora.Location = new System.Drawing.Point(12, 213);
            this.maskedTextBoxHora.Name = "maskedTextBoxHora";
            this.maskedTextBoxHora.Size = new System.Drawing.Size(329, 22);
            this.maskedTextBoxHora.TabIndex = 4;
            // 
            // maskedTextBoxDecimais
            // 
            this.maskedTextBoxDecimais.Location = new System.Drawing.Point(12, 264);
            this.maskedTextBoxDecimais.Name = "maskedTextBoxDecimais";
            this.maskedTextBoxDecimais.Size = new System.Drawing.Size(329, 22);
            this.maskedTextBoxDecimais.TabIndex = 5;
            // 
            // maskedTextBoxSenha
            // 
            this.maskedTextBoxSenha.Location = new System.Drawing.Point(12, 321);
            this.maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            this.maskedTextBoxSenha.Size = new System.Drawing.Size(329, 22);
            this.maskedTextBoxSenha.TabIndex = 6;
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(12, 388);
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(329, 22);
            this.maskedTextBoxCelular.TabIndex = 7;
            // 
            // botaoVerifica
            // 
            this.botaoVerifica.Location = new System.Drawing.Point(449, 34);
            this.botaoVerifica.Name = "botaoVerifica";
            this.botaoVerifica.Size = new System.Drawing.Size(199, 38);
            this.botaoVerifica.TabIndex = 8;
            this.botaoVerifica.Text = "Verifica";
            this.botaoVerifica.UseVisualStyleBackColor = true;
            this.botaoVerifica.Click += new System.EventHandler(this.botaoVerifica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoVerifica);
            this.Controls.Add(this.maskedTextBoxCelular);
            this.Controls.Add(this.maskedTextBoxSenha);
            this.Controls.Add(this.maskedTextBoxDecimais);
            this.Controls.Add(this.maskedTextBoxHora);
            this.Controls.Add(this.maskedTextBoxPlacaDeCarro);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.maskedTextBoxLetras);
            this.Controls.Add(this.maskedTextBoxNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumeros;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLetras;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlacaDeCarro;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHora;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDecimais;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSenha;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.Button botaoVerifica;
    }
}

