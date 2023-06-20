namespace Projeto12BatePapoOnline
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
            this.groupBoxMensagens = new System.Windows.Forms.GroupBox();
            this.buttonEnviarMensagem = new System.Windows.Forms.Button();
            this.textBoxPortaDoContato = new System.Windows.Forms.TextBox();
            this.textBoxIpDoContato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMensagensParaEnviar = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMensagens = new System.Windows.Forms.RichTextBox();
            this.textBoxMeuNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxServidor = new System.Windows.Forms.GroupBox();
            this.buttonAplicarConfigServidor = new System.Windows.Forms.Button();
            this.textBoxPortaDoSerivdor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxMensagens.SuspendLayout();
            this.groupBoxServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMensagens
            // 
            this.groupBoxMensagens.Controls.Add(this.buttonEnviarMensagem);
            this.groupBoxMensagens.Controls.Add(this.textBoxPortaDoContato);
            this.groupBoxMensagens.Controls.Add(this.textBoxIpDoContato);
            this.groupBoxMensagens.Controls.Add(this.label4);
            this.groupBoxMensagens.Controls.Add(this.label3);
            this.groupBoxMensagens.Controls.Add(this.label2);
            this.groupBoxMensagens.Controls.Add(this.richTextBoxMensagensParaEnviar);
            this.groupBoxMensagens.Controls.Add(this.richTextBoxMensagens);
            this.groupBoxMensagens.Controls.Add(this.textBoxMeuNome);
            this.groupBoxMensagens.Controls.Add(this.label1);
            this.groupBoxMensagens.Location = new System.Drawing.Point(43, 41);
            this.groupBoxMensagens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMensagens.Name = "groupBoxMensagens";
            this.groupBoxMensagens.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMensagens.Size = new System.Drawing.Size(701, 495);
            this.groupBoxMensagens.TabIndex = 0;
            this.groupBoxMensagens.TabStop = false;
            this.groupBoxMensagens.Text = "Mensagens";
            // 
            // buttonEnviarMensagem
            // 
            this.buttonEnviarMensagem.Location = new System.Drawing.Point(76, 406);
            this.buttonEnviarMensagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnviarMensagem.Name = "buttonEnviarMensagem";
            this.buttonEnviarMensagem.Size = new System.Drawing.Size(457, 64);
            this.buttonEnviarMensagem.TabIndex = 9;
            this.buttonEnviarMensagem.Text = "Enviar mensagem";
            this.buttonEnviarMensagem.UseVisualStyleBackColor = true;
            this.buttonEnviarMensagem.Click += new System.EventHandler(this.buttonEnviarMensagem_Click);
            // 
            // textBoxPortaDoContato
            // 
            this.textBoxPortaDoContato.Location = new System.Drawing.Point(484, 370);
            this.textBoxPortaDoContato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPortaDoContato.Name = "textBoxPortaDoContato";
            this.textBoxPortaDoContato.Size = new System.Drawing.Size(132, 22);
            this.textBoxPortaDoContato.TabIndex = 8;
            // 
            // textBoxIpDoContato
            // 
            this.textBoxIpDoContato.Location = new System.Drawing.Point(149, 374);
            this.textBoxIpDoContato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIpDoContato.Name = "textBoxIpDoContato";
            this.textBoxIpDoContato.Size = new System.Drawing.Size(183, 22);
            this.textBoxIpDoContato.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Porta do contato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ip do contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensagens para enviar:";
            // 
            // richTextBoxMensagensParaEnviar
            // 
            this.richTextBoxMensagensParaEnviar.Location = new System.Drawing.Point(215, 271);
            this.richTextBoxMensagensParaEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxMensagensParaEnviar.Name = "richTextBoxMensagensParaEnviar";
            this.richTextBoxMensagensParaEnviar.Size = new System.Drawing.Size(449, 66);
            this.richTextBoxMensagensParaEnviar.TabIndex = 3;
            this.richTextBoxMensagensParaEnviar.Text = "";
            // 
            // richTextBoxMensagens
            // 
            this.richTextBoxMensagens.Enabled = false;
            this.richTextBoxMensagens.Location = new System.Drawing.Point(44, 80);
            this.richTextBoxMensagens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxMensagens.Name = "richTextBoxMensagens";
            this.richTextBoxMensagens.Size = new System.Drawing.Size(620, 162);
            this.richTextBoxMensagens.TabIndex = 2;
            this.richTextBoxMensagens.Text = "";
            // 
            // textBoxMeuNome
            // 
            this.textBoxMeuNome.Location = new System.Drawing.Point(149, 31);
            this.textBoxMeuNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMeuNome.Name = "textBoxMeuNome";
            this.textBoxMeuNome.Size = new System.Drawing.Size(497, 22);
            this.textBoxMeuNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meu Nome: ";
            // 
            // groupBoxServidor
            // 
            this.groupBoxServidor.Controls.Add(this.buttonAplicarConfigServidor);
            this.groupBoxServidor.Controls.Add(this.textBoxPortaDoSerivdor);
            this.groupBoxServidor.Controls.Add(this.label5);
            this.groupBoxServidor.Location = new System.Drawing.Point(43, 543);
            this.groupBoxServidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxServidor.Name = "groupBoxServidor";
            this.groupBoxServidor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxServidor.Size = new System.Drawing.Size(701, 165);
            this.groupBoxServidor.TabIndex = 1;
            this.groupBoxServidor.TabStop = false;
            this.groupBoxServidor.Text = "Configurações do Servidor";
            // 
            // buttonAplicarConfigServidor
            // 
            this.buttonAplicarConfigServidor.Location = new System.Drawing.Point(27, 76);
            this.buttonAplicarConfigServidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAplicarConfigServidor.Name = "buttonAplicarConfigServidor";
            this.buttonAplicarConfigServidor.Size = new System.Drawing.Size(507, 81);
            this.buttonAplicarConfigServidor.TabIndex = 2;
            this.buttonAplicarConfigServidor.Text = "Aplicar configurações";
            this.buttonAplicarConfigServidor.UseVisualStyleBackColor = true;
            this.buttonAplicarConfigServidor.Click += new System.EventHandler(this.buttonAplicarConfigServidor_Click);
            // 
            // textBoxPortaDoSerivdor
            // 
            this.textBoxPortaDoSerivdor.Location = new System.Drawing.Point(177, 28);
            this.textBoxPortaDoSerivdor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPortaDoSerivdor.Name = "textBoxPortaDoSerivdor";
            this.textBoxPortaDoSerivdor.Size = new System.Drawing.Size(469, 22);
            this.textBoxPortaDoSerivdor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Porta do servidor: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 743);
            this.Controls.Add(this.groupBoxServidor);
            this.Controls.Add(this.groupBoxMensagens);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(813, 782);
            this.MinimumSize = new System.Drawing.Size(813, 782);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBoxMensagens.ResumeLayout(false);
            this.groupBoxMensagens.PerformLayout();
            this.groupBoxServidor.ResumeLayout(false);
            this.groupBoxServidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMensagens;
        private System.Windows.Forms.GroupBox groupBoxServidor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxMensagensParaEnviar;
        private System.Windows.Forms.RichTextBox richTextBoxMensagens;
        private System.Windows.Forms.TextBox textBoxMeuNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnviarMensagem;
        private System.Windows.Forms.TextBox textBoxPortaDoContato;
        private System.Windows.Forms.TextBox textBoxIpDoContato;
        private System.Windows.Forms.Button buttonAplicarConfigServidor;
        private System.Windows.Forms.TextBox textBoxPortaDoSerivdor;
        private System.Windows.Forms.Label label5;
    }
}

