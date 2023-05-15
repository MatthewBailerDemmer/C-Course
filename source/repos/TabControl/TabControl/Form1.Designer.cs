namespace TabControl
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
            this.BotaoTab1 = new System.Windows.Forms.Button();
            this.BotaoTab2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BotaoMudaFundoTab1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BotaoTab1
            // 
            this.BotaoTab1.Location = new System.Drawing.Point(691, 51);
            this.BotaoTab1.Name = "BotaoTab1";
            this.BotaoTab1.Size = new System.Drawing.Size(75, 23);
            this.BotaoTab1.TabIndex = 0;
            this.BotaoTab1.Text = "Tab 1";
            this.BotaoTab1.UseVisualStyleBackColor = true;
            this.BotaoTab1.Click += new System.EventHandler(this.BotaoTab1_Click);
            // 
            // BotaoTab2
            // 
            this.BotaoTab2.Location = new System.Drawing.Point(691, 96);
            this.BotaoTab2.Name = "BotaoTab2";
            this.BotaoTab2.Size = new System.Drawing.Size(75, 23);
            this.BotaoTab2.TabIndex = 1;
            this.BotaoTab2.Text = "Tab 2";
            this.BotaoTab2.UseVisualStyleBackColor = true;
            this.BotaoTab2.Click += new System.EventHandler(this.BotaoTab2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TabControl.Properties.Resources.Gaming_5000x3125;
            this.pictureBox1.Location = new System.Drawing.Point(265, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(166, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(166, 107);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // BotaoMudaFundoTab1
            // 
            this.BotaoMudaFundoTab1.Location = new System.Drawing.Point(691, 145);
            this.BotaoMudaFundoTab1.Name = "BotaoMudaFundoTab1";
            this.BotaoMudaFundoTab1.Size = new System.Drawing.Size(97, 23);
            this.BotaoMudaFundoTab1.TabIndex = 2;
            this.BotaoMudaFundoTab1.Text = "MudaFundoTab1";
            this.BotaoMudaFundoTab1.UseVisualStyleBackColor = true;
            this.BotaoMudaFundoTab1.Click += new System.EventHandler(this.BotaoMudaFundoTab1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoMudaFundoTab1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BotaoTab1);
            this.Controls.Add(this.BotaoTab2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BotaoTab2;
        private System.Windows.Forms.Button BotaoTab1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotaoMudaFundoTab1;
    }
}

