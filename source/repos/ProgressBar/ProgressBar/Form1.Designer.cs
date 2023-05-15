namespace ProgressBar
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
            this.trackAtiva = new System.Windows.Forms.TrackBar();
            this.progressBarPassivo = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackAtiva)).BeginInit();
            this.SuspendLayout();
            // 
            // trackAtiva
            // 
            this.trackAtiva.Location = new System.Drawing.Point(55, 54);
            this.trackAtiva.Maximum = 100;
            this.trackAtiva.Name = "trackAtiva";
            this.trackAtiva.Size = new System.Drawing.Size(104, 56);
            this.trackAtiva.TabIndex = 0;
            this.trackAtiva.ValueChanged += new System.EventHandler(this.trackAtiva_ValueChanged);
            // 
            // progressBarPassivo
            // 
            this.progressBarPassivo.Location = new System.Drawing.Point(51, 194);
            this.progressBarPassivo.Name = "progressBarPassivo";
            this.progressBarPassivo.Size = new System.Drawing.Size(177, 23);
            this.progressBarPassivo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarPassivo);
            this.Controls.Add(this.trackAtiva);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackAtiva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackAtiva;
        private System.Windows.Forms.ProgressBar progressBarPassivo;
    }
}

