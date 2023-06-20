namespace Temporizadores
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
            this.components = new System.ComponentModel.Container();
            this.TimerInterfaceGrafica = new System.Windows.Forms.Timer(this.components);
            this.BotaoHabilitar = new System.Windows.Forms.Button();
            this.BotaoDesabilitar = new System.Windows.Forms.Button();
            this.botaoHabilitaCodigo = new System.Windows.Forms.Button();
            this.desabilitaPorCodigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerInterfaceGrafica
            // 
            this.TimerInterfaceGrafica.Enabled = true;
            this.TimerInterfaceGrafica.Interval = 5000;
            this.TimerInterfaceGrafica.Tick += new System.EventHandler(this.TimerInterfaceGrafica_Tick);
            // 
            // BotaoHabilitar
            // 
            this.BotaoHabilitar.Location = new System.Drawing.Point(108, 52);
            this.BotaoHabilitar.Name = "BotaoHabilitar";
            this.BotaoHabilitar.Size = new System.Drawing.Size(282, 44);
            this.BotaoHabilitar.TabIndex = 0;
            this.BotaoHabilitar.Text = "Habilitar timer interface gráfica";
            this.BotaoHabilitar.UseVisualStyleBackColor = true;
            this.BotaoHabilitar.Click += new System.EventHandler(this.BotaoHabilitar_Click);
            // 
            // BotaoDesabilitar
            // 
            this.BotaoDesabilitar.Location = new System.Drawing.Point(108, 135);
            this.BotaoDesabilitar.Name = "BotaoDesabilitar";
            this.BotaoDesabilitar.Size = new System.Drawing.Size(282, 30);
            this.BotaoDesabilitar.TabIndex = 1;
            this.BotaoDesabilitar.Text = "Desabilitar timer interface gráfica";
            this.BotaoDesabilitar.UseVisualStyleBackColor = true;
            this.BotaoDesabilitar.Click += new System.EventHandler(this.BotaoDesabilitar_Click);
            // 
            // botaoHabilitaCodigo
            // 
            this.botaoHabilitaCodigo.Location = new System.Drawing.Point(114, 227);
            this.botaoHabilitaCodigo.Name = "botaoHabilitaCodigo";
            this.botaoHabilitaCodigo.Size = new System.Drawing.Size(276, 23);
            this.botaoHabilitaCodigo.TabIndex = 2;
            this.botaoHabilitaCodigo.Text = "Habilita timer por código";
            this.botaoHabilitaCodigo.UseVisualStyleBackColor = true;
            this.botaoHabilitaCodigo.Click += new System.EventHandler(this.botaoHabilitaCodigo_Click);
            // 
            // desabilitaPorCodigo
            // 
            this.desabilitaPorCodigo.Location = new System.Drawing.Point(113, 305);
            this.desabilitaPorCodigo.Name = "desabilitaPorCodigo";
            this.desabilitaPorCodigo.Size = new System.Drawing.Size(277, 23);
            this.desabilitaPorCodigo.TabIndex = 3;
            this.desabilitaPorCodigo.Text = "Desabilita timer por código";
            this.desabilitaPorCodigo.UseVisualStyleBackColor = true;
            this.desabilitaPorCodigo.Click += new System.EventHandler(this.desabilitaPorCodigo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desabilitaPorCodigo);
            this.Controls.Add(this.botaoHabilitaCodigo);
            this.Controls.Add(this.BotaoDesabilitar);
            this.Controls.Add(this.BotaoHabilitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerInterfaceGrafica;
        private System.Windows.Forms.Button BotaoHabilitar;
        private System.Windows.Forms.Button BotaoDesabilitar;
        private System.Windows.Forms.Button botaoHabilitaCodigo;
        private System.Windows.Forms.Button desabilitaPorCodigo;
    }
}

