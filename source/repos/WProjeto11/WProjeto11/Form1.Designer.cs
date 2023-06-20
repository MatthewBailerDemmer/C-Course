namespace WProjeto11
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
            Cadastro = new TabControl();
            tabPage1 = new TabPage();
            buttonCadastrar = new Button();
            textBoxNumeroCasa = new TextBox();
            textBoxDataDeNascimento = new TextBox();
            textBoxNomeDaRua = new TextBox();
            textNumeroDocumento1 = new TextBox();
            textBoxNomeCompleto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            buttonExcluir = new Button();
            buttonBuscar = new Button();
            labelCasa = new Label();
            labelRua = new Label();
            labelNascimento = new Label();
            labelNome = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Cadastro.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Cadastro
            // 
            Cadastro.Controls.Add(tabPage1);
            Cadastro.Controls.Add(tabPage2);
            Cadastro.Location = new Point(12, 12);
            Cadastro.Name = "Cadastro";
            Cadastro.SelectedIndex = 0;
            Cadastro.Size = new Size(776, 426);
            Cadastro.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonCadastrar);
            tabPage1.Controls.Add(textBoxNumeroCasa);
            tabPage1.Controls.Add(textBoxDataDeNascimento);
            tabPage1.Controls.Add(textBoxNomeDaRua);
            tabPage1.Controls.Add(textNumeroDocumento1);
            tabPage1.Controls.Add(textBoxNomeCompleto);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrar.Location = new Point(24, 249);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(215, 101);
            buttonCadastrar.TabIndex = 20;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxNumeroCasa
            // 
            textBoxNumeroCasa.Location = new Point(174, 153);
            textBoxNumeroCasa.Name = "textBoxNumeroCasa";
            textBoxNumeroCasa.Size = new Size(279, 23);
            textBoxNumeroCasa.TabIndex = 19;
            // 
            // textBoxDataDeNascimento
            // 
            textBoxDataDeNascimento.Location = new Point(174, 90);
            textBoxDataDeNascimento.Name = "textBoxDataDeNascimento";
            textBoxDataDeNascimento.Size = new Size(279, 23);
            textBoxDataDeNascimento.TabIndex = 18;
            // 
            // textBoxNomeDaRua
            // 
            textBoxNomeDaRua.Location = new Point(174, 121);
            textBoxNomeDaRua.Name = "textBoxNomeDaRua";
            textBoxNomeDaRua.Size = new Size(279, 23);
            textBoxNomeDaRua.TabIndex = 17;
            // 
            // textNumeroDocumento1
            // 
            textNumeroDocumento1.Location = new Point(174, 56);
            textNumeroDocumento1.Name = "textNumeroDocumento1";
            textNumeroDocumento1.Size = new Size(279, 23);
            textNumeroDocumento1.TabIndex = 16;
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Location = new Point(174, 22);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(279, 23);
            textBoxNomeCompleto.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 156);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 14;
            label5.Text = "Número da casa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 124);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 13;
            label4.Text = "Nome da rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 59);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 12;
            label3.Text = "Número do documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 11;
            label2.Text = "Data de nascimento: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome Completo:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonExcluir);
            tabPage2.Controls.Add(buttonBuscar);
            tabPage2.Controls.Add(labelCasa);
            tabPage2.Controls.Add(labelRua);
            tabPage2.Controls.Add(labelNascimento);
            tabPage2.Controls.Add(labelNome);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.Location = new Point(416, 245);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(249, 91);
            buttonExcluir.TabIndex = 26;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(24, 245);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(277, 91);
            buttonBuscar.TabIndex = 25;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelCasa
            // 
            labelCasa.AutoSize = true;
            labelCasa.Location = new Point(189, 148);
            labelCasa.Name = "labelCasa";
            labelCasa.Size = new Size(12, 15);
            labelCasa.TabIndex = 24;
            labelCasa.Text = "-";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.Location = new Point(189, 116);
            labelRua.Name = "labelRua";
            labelRua.Size = new Size(12, 15);
            labelRua.TabIndex = 23;
            labelRua.Text = "-";
            // 
            // labelNascimento
            // 
            labelNascimento.AutoSize = true;
            labelNascimento.Location = new Point(189, 85);
            labelNascimento.Name = "labelNascimento";
            labelNascimento.Size = new Size(12, 15);
            labelNascimento.TabIndex = 22;
            labelNascimento.Text = "-";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(189, 57);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(12, 15);
            labelNome.TabIndex = 21;
            labelNome.Text = "-";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(189, 17);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(199, 23);
            textBox6.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 148);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 19;
            label6.Text = "Número da casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 116);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 18;
            label7.Text = "Nome da rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 20);
            label8.Name = "label8";
            label8.Size = new Size(136, 15);
            label8.TabIndex = 17;
            label8.Text = "Número do documento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 85);
            label9.Name = "label9";
            label9.Size = new Size(118, 15);
            label9.TabIndex = 16;
            label9.Text = "Data de nascimento: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 57);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 15;
            label10.Text = "Nome Completo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cadastro);
            Name = "Form1";
            Text = "Form1";
            Cadastro.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Cadastro;
        private TabPage tabPage1;
        private Button buttonCadastrar;
        private TextBox textBoxNumeroCasa;
        private TextBox textBoxDataDeNascimento;
        private TextBox textBoxNomeDaRua;
        private TextBox textNumeroDocumento1;
        private TextBox textBoxNomeCompleto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button buttonExcluir;
        private Button buttonBuscar;
        private Label labelCasa;
        private Label labelRua;
        private Label labelNascimento;
        private Label labelNome;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}