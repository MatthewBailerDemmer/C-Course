namespace ComunicacaoArduino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBoxComs = new ComboBox();
            buttonConectar = new Button();
            textBoxDadosEnviados = new TextBox();
            richTextBoxDadosRecebidos = new RichTextBox();
            buttonEnviar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // comboBoxComs
            // 
            comboBoxComs.FormattingEnabled = true;
            comboBoxComs.Location = new Point(43, 38);
            comboBoxComs.Name = "comboBoxComs";
            comboBoxComs.Size = new Size(121, 23);
            comboBoxComs.TabIndex = 0;
            // 
            // buttonConectar
            // 
            buttonConectar.Location = new Point(184, 37);
            buttonConectar.Name = "buttonConectar";
            buttonConectar.Size = new Size(75, 23);
            buttonConectar.TabIndex = 1;
            buttonConectar.Text = "Conectar";
            buttonConectar.UseVisualStyleBackColor = true;
            buttonConectar.Click += buttonConectar_Click;
            // 
            // textBoxDadosEnviados
            // 
            textBoxDadosEnviados.Location = new Point(42, 79);
            textBoxDadosEnviados.Name = "textBoxDadosEnviados";
            textBoxDadosEnviados.Size = new Size(122, 23);
            textBoxDadosEnviados.TabIndex = 2;
            // 
            // richTextBoxDadosRecebidos
            // 
            richTextBoxDadosRecebidos.Location = new Point(43, 136);
            richTextBoxDadosRecebidos.Name = "richTextBoxDadosRecebidos";
            richTextBoxDadosRecebidos.Size = new Size(132, 145);
            richTextBoxDadosRecebidos.TabIndex = 3;
            richTextBoxDadosRecebidos.Text = "";
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(184, 79);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 202);
            buttonEnviar.TabIndex = 4;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEnviar);
            Controls.Add(richTextBoxDadosRecebidos);
            Controls.Add(textBoxDadosEnviados);
            Controls.Add(buttonConectar);
            Controls.Add(comboBoxComs);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxComs;
        private Button buttonConectar;
        private TextBox textBoxDadosEnviados;
        private RichTextBox richTextBoxDadosRecebidos;
        private Button buttonEnviar;
        private System.Windows.Forms.Timer timer1;
    }
}