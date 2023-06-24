namespace Projeto13
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNúmeroDaCasa = new System.Windows.Forms.TextBox();
            this.textBoxNomeDaRua = new System.Windows.Forms.TextBox();
            this.textBoxDataDeNascimento = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPesquisaDocumento = new System.Windows.Forms.TextBox();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridViewCadastro = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCadastrar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxNúmeroDaCasa);
            this.tabPage1.Controls.Add(this.textBoxNomeDaRua);
            this.tabPage1.Controls.Add(this.textBoxDataDeNascimento);
            this.tabPage1.Controls.Add(this.textBoxDocumento);
            this.tabPage1.Controls.Add(this.textBoxNomeCompleto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewCadastro);
            this.tabPage2.Controls.Add(this.buttonExcluir);
            this.tabPage2.Controls.Add(this.buttonPesquisa);
            this.tabPage2.Controls.Add(this.textBoxPesquisaDocumento);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(37, 251);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(152, 45);
            this.buttonCadastrar.TabIndex = 21;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Número da casa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nom da rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data de nascimento: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome completo:";
            // 
            // textBoxNúmeroDaCasa
            // 
            this.textBoxNúmeroDaCasa.Location = new System.Drawing.Point(164, 204);
            this.textBoxNúmeroDaCasa.Name = "textBoxNúmeroDaCasa";
            this.textBoxNúmeroDaCasa.Size = new System.Drawing.Size(292, 20);
            this.textBoxNúmeroDaCasa.TabIndex = 15;
            // 
            // textBoxNomeDaRua
            // 
            this.textBoxNomeDaRua.Location = new System.Drawing.Point(164, 154);
            this.textBoxNomeDaRua.Name = "textBoxNomeDaRua";
            this.textBoxNomeDaRua.Size = new System.Drawing.Size(292, 20);
            this.textBoxNomeDaRua.TabIndex = 14;
            // 
            // textBoxDataDeNascimento
            // 
            this.textBoxDataDeNascimento.Location = new System.Drawing.Point(164, 106);
            this.textBoxDataDeNascimento.Name = "textBoxDataDeNascimento";
            this.textBoxDataDeNascimento.Size = new System.Drawing.Size(292, 20);
            this.textBoxDataDeNascimento.TabIndex = 13;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(164, 66);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(292, 20);
            this.textBoxDocumento.TabIndex = 12;
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(164, 28);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(292, 20);
            this.textBoxNomeCompleto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Documento:";
            // 
            // textBoxPesquisaDocumento
            // 
            this.textBoxPesquisaDocumento.Location = new System.Drawing.Point(118, 43);
            this.textBoxPesquisaDocumento.Name = "textBoxPesquisaDocumento";
            this.textBoxPesquisaDocumento.Size = new System.Drawing.Size(183, 20);
            this.textBoxPesquisaDocumento.TabIndex = 1;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Location = new System.Drawing.Point(366, 24);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(106, 51);
            this.buttonPesquisa.TabIndex = 2;
            this.buttonPesquisa.Text = "Pesquisar";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(513, 27);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(106, 51);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dataGridViewCadastro
            // 
            this.dataGridViewCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCadastro.Location = new System.Drawing.Point(95, 137);
            this.dataGridViewCadastro.Name = "dataGridViewCadastro";
            this.dataGridViewCadastro.Size = new System.Drawing.Size(487, 196);
            this.dataGridViewCadastro.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNúmeroDaCasa;
        private System.Windows.Forms.TextBox textBoxNomeDaRua;
        private System.Windows.Forms.TextBox textBoxDataDeNascimento;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.TextBox textBoxPesquisaDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewCadastro;
        private System.Windows.Forms.Button buttonExcluir;
    }
}

