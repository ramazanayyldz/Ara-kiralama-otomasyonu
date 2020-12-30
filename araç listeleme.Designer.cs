namespace Araç_kiralama_otomasyonu
{
    partial class araç_listeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.araçlarcombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yakıtcombo = new System.Windows.Forms.ComboBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.txtkira = new System.Windows.Forms.MaskedTextBox();
            this.txtkm = new System.Windows.Forms.MaskedTextBox();
            this.txtrenk = new System.Windows.Forms.MaskedTextBox();
            this.txtmodel = new System.Windows.Forms.MaskedTextBox();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 533);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // araçlarcombo
            // 
            this.araçlarcombo.FormattingEnabled = true;
            this.araçlarcombo.Items.AddRange(new object[] {
            "Tüm Araçalar",
            "Boş Araçalar",
            "Dolu Araçlar"});
            this.araçlarcombo.Location = new System.Drawing.Point(919, -1);
            this.araçlarcombo.Name = "araçlarcombo";
            this.araçlarcombo.Size = new System.Drawing.Size(121, 24);
            this.araçlarcombo.TabIndex = 1;
            this.araçlarcombo.SelectedIndexChanged += new System.EventHandler(this.araçlarcombo_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(8, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 52);
            this.button3.TabIndex = 35;
            this.button3.Text = "resim Degiştir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(159, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 34;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(27, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 33;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(5, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = " Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(7, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = " Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(5, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = " KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(5, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = " Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(5, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Model(yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(5, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = " Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = " Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = " Plaka";
            // 
            // yakıtcombo
            // 
            this.yakıtcombo.BackColor = System.Drawing.SystemColors.Info;
            this.yakıtcombo.FormattingEnabled = true;
            this.yakıtcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.yakıtcombo.Location = new System.Drawing.Point(89, 288);
            this.yakıtcombo.Name = "yakıtcombo";
            this.yakıtcombo.Size = new System.Drawing.Size(121, 24);
            this.yakıtcombo.TabIndex = 23;
            // 
            // sericombo
            // 
            this.sericombo.BackColor = System.Drawing.SystemColors.Info;
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(89, 106);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(121, 24);
            this.sericombo.TabIndex = 22;
            // 
            // markacombo
            // 
            this.markacombo.BackColor = System.Drawing.SystemColors.Info;
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat"});
            this.markacombo.Location = new System.Drawing.Point(89, 54);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(121, 24);
            this.markacombo.TabIndex = 21;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.markacombo_SelectedIndexChanged);
            // 
            // txtkira
            // 
            this.txtkira.BackColor = System.Drawing.SystemColors.Info;
            this.txtkira.Location = new System.Drawing.Point(89, 331);
            this.txtkira.Name = "txtkira";
            this.txtkira.Size = new System.Drawing.Size(122, 22);
            this.txtkira.TabIndex = 19;
            // 
            // txtkm
            // 
            this.txtkm.BackColor = System.Drawing.SystemColors.Info;
            this.txtkm.Location = new System.Drawing.Point(91, 246);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(120, 22);
            this.txtkm.TabIndex = 18;
            // 
            // txtrenk
            // 
            this.txtrenk.BackColor = System.Drawing.SystemColors.Info;
            this.txtrenk.Location = new System.Drawing.Point(91, 201);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(121, 22);
            this.txtrenk.TabIndex = 17;
            // 
            // txtmodel
            // 
            this.txtmodel.BackColor = System.Drawing.SystemColors.Info;
            this.txtmodel.Location = new System.Drawing.Point(91, 156);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(121, 22);
            this.txtmodel.TabIndex = 20;
            // 
            // txtplaka
            // 
            this.txtplaka.BackColor = System.Drawing.SystemColors.Info;
            this.txtplaka.Enabled = false;
            this.txtplaka.Location = new System.Drawing.Point(88, 11);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(122, 22);
            this.txtplaka.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(1054, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 47);
            this.button4.TabIndex = 34;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(88, 370);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // araç_listeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1175, 777);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
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
            this.Controls.Add(this.araçlarcombo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "araç_listeleme";
            this.Text = "araç_listeleme";
            this.Load += new System.EventHandler(this.araç_listeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox araçlarcombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yakıtcombo;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.MaskedTextBox txtkira;
        private System.Windows.Forms.MaskedTextBox txtkm;
        private System.Windows.Forms.MaskedTextBox txtrenk;
        private System.Windows.Forms.MaskedTextBox txtmodel;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}