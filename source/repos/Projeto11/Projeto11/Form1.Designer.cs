namespace Projeto11
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelNomeRua = new System.Windows.Forms.Label();
            this.labelNumeroCasa = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonBusca = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 19);
            this.tabControl1.MaximumSize = new System.Drawing.Size(752, 419);
            this.tabControl1.MinimumSize = new System.Drawing.Size(752, 419);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCadastrar);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonBusca);
            this.tabPage2.Controls.Add(this.buttonExcluir);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.labelNumeroCasa);
            this.tabPage2.Controls.Add(this.labelNomeRua);
            this.tabPage2.Controls.Add(this.labelDataNascimento);
            this.tabPage2.Controls.Add(this.labelNomeCompleto);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número do documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome da rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número da casa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(187, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 22);
            this.textBox5.TabIndex = 9;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(9, 217);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(218, 62);
            this.buttonCadastrar.TabIndex = 10;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Número da casa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome da rua:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data de nascimento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Número do documento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nome Completo:";
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Location = new System.Drawing.Point(236, 30);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(11, 16);
            this.labelNomeCompleto.TabIndex = 10;
            this.labelNomeCompleto.Text = "-";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(236, 90);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(11, 16);
            this.labelDataNascimento.TabIndex = 12;
            this.labelDataNascimento.Text = "-";
            // 
            // labelNomeRua
            // 
            this.labelNomeRua.AutoSize = true;
            this.labelNomeRua.Location = new System.Drawing.Point(236, 125);
            this.labelNomeRua.Name = "labelNomeRua";
            this.labelNomeRua.Size = new System.Drawing.Size(11, 16);
            this.labelNomeRua.TabIndex = 13;
            this.labelNomeRua.Text = "-";
            // 
            // labelNumeroCasa
            // 
            this.labelNumeroCasa.AutoSize = true;
            this.labelNumeroCasa.Location = new System.Drawing.Point(236, 166);
            this.labelNumeroCasa.Name = "labelNumeroCasa";
            this.labelNumeroCasa.Size = new System.Drawing.Size(11, 16);
            this.labelNumeroCasa.TabIndex = 14;
            this.labelNumeroCasa.Text = "-";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(229, 54);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(213, 22);
            this.textBox6.TabIndex = 15;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(346, 263);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(220, 80);
            this.buttonExcluir.TabIndex = 16;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonBusca
            // 
            this.buttonBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusca.Location = new System.Drawing.Point(30, 263);
            this.buttonBusca.Name = "buttonBusca";
            this.buttonBusca.Size = new System.Drawing.Size(207, 80);
            this.buttonBusca.TabIndex = 17;
            this.buttonBusca.Text = "Buscar";
            this.buttonBusca.UseVisualStyleBackColor = true;
            this.buttonBusca.Click += new System.EventHandler(this.buttonBusca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonBusca;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelNumeroCasa;
        private System.Windows.Forms.Label labelNomeRua;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

