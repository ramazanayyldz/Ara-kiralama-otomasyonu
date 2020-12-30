namespace Araç_kiralama_otomasyonu
{
    partial class Araç_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.MaskedTextBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.txtrenk = new System.Windows.Forms.MaskedTextBox();
            this.txtkm = new System.Windows.Forms.MaskedTextBox();
            this.yakıtcombo = new System.Windows.Forms.ComboBox();
            this.txtkira = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtplaka
            // 
            this.txtplaka.BackColor = System.Drawing.SystemColors.Info;
            this.txtplaka.Location = new System.Drawing.Point(93, 23);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(166, 22);
            this.txtplaka.TabIndex = 0;
            // 
            // txtmodel
            // 
            this.txtmodel.BackColor = System.Drawing.SystemColors.Info;
            this.txtmodel.Location = new System.Drawing.Point(96, 168);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(165, 22);
            this.txtmodel.TabIndex = 1;
            // 
            // markacombo
            // 
            this.markacombo.BackColor = System.Drawing.SystemColors.Info;
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat"});
            this.markacombo.Location = new System.Drawing.Point(94, 66);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(165, 24);
            this.markacombo.TabIndex = 2;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sericombo
            // 
            this.sericombo.BackColor = System.Drawing.SystemColors.Info;
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(94, 118);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(165, 24);
            this.sericombo.TabIndex = 3;
            // 
            // txtrenk
            // 
            this.txtrenk.BackColor = System.Drawing.SystemColors.Info;
            this.txtrenk.Location = new System.Drawing.Point(96, 213);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(165, 22);
            this.txtrenk.TabIndex = 1;
            // 
            // txtkm
            // 
            this.txtkm.BackColor = System.Drawing.SystemColors.Info;
            this.txtkm.Location = new System.Drawing.Point(96, 258);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(164, 22);
            this.txtkm.TabIndex = 1;
            // 
            // yakıtcombo
            // 
            this.yakıtcombo.BackColor = System.Drawing.SystemColors.Info;
            this.yakıtcombo.FormattingEnabled = true;
            this.yakıtcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.yakıtcombo.Location = new System.Drawing.Point(94, 300);
            this.yakıtcombo.Name = "yakıtcombo";
            this.yakıtcombo.Size = new System.Drawing.Size(165, 24);
            this.yakıtcombo.TabIndex = 3;
            // 
            // txtkira
            // 
            this.txtkira.BackColor = System.Drawing.SystemColors.Info;
            this.txtkira.Location = new System.Drawing.Point(94, 343);
            this.txtkira.Name = "txtkira";
            this.txtkira.Size = new System.Drawing.Size(166, 22);
            this.txtkira.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = " Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = " Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = " Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(10, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model(yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(10, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = " Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(10, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = " KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(12, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = " Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(10, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = " Kira Ücreti";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(294, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(24, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(150, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(324, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 52);
            this.button3.TabIndex = 15;
            this.button3.Text = "resim Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Araç_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(471, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yakıtcombo);
            this.Controls.Add(this.sericombo);
            this.Controls.Add(this.markacombo);
            this.Controls.Add(this.txtkira);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtplaka);
            this.Name = "Araç_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç_Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.MaskedTextBox txtmodel;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.MaskedTextBox txtrenk;
        private System.Windows.Forms.MaskedTextBox txtkm;
        private System.Windows.Forms.ComboBox yakıtcombo;
        private System.Windows.Forms.MaskedTextBox txtkira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}