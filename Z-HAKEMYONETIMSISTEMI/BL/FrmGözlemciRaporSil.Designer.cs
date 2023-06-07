namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmGözlemciRaporSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGözlemciRaporSil));
            this.txtGözleciIsim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskMacSonuc = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGözlemciYorum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHakemIsim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGözlemciRaporDüzenle = new System.Windows.Forms.Button();
            this.cmbTakim2 = new System.Windows.Forms.ComboBox();
            this.cmbTakim1 = new System.Windows.Forms.ComboBox();
            this.txtMacNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGözleciIsim
            // 
            this.txtGözleciIsim.Location = new System.Drawing.Point(178, 388);
            this.txtGözleciIsim.Name = "txtGözleciIsim";
            this.txtGözleciIsim.Size = new System.Drawing.Size(178, 31);
            this.txtGözleciIsim.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 23);
            this.label8.TabIndex = 57;
            this.label8.Text = "Gözlemci Isim : ";
            // 
            // mskMacSonuc
            // 
            this.mskMacSonuc.Location = new System.Drawing.Point(178, 295);
            this.mskMacSonuc.Mask = "0 - 0 ";
            this.mskMacSonuc.Name = "mskMacSonuc";
            this.mskMacSonuc.Size = new System.Drawing.Size(177, 31);
            this.mskMacSonuc.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 369);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtGözlemciYorum
            // 
            this.txtGözlemciYorum.Location = new System.Drawing.Point(178, 345);
            this.txtGözlemciYorum.Name = "txtGözlemciYorum";
            this.txtGözlemciYorum.Size = new System.Drawing.Size(178, 31);
            this.txtGözlemciYorum.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 23);
            this.label7.TabIndex = 53;
            this.label7.Text = "Hakem Yorum : ";
            // 
            // txtHakemIsim
            // 
            this.txtHakemIsim.Location = new System.Drawing.Point(177, 151);
            this.txtHakemIsim.Name = "txtHakemIsim";
            this.txtHakemIsim.Size = new System.Drawing.Size(178, 31);
            this.txtHakemIsim.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Hakem İsim : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "GÖZLEMCİ RAPOR SİLME PANELİ";
            // 
            // btnGözlemciRaporDüzenle
            // 
            this.btnGözlemciRaporDüzenle.Location = new System.Drawing.Point(51, 425);
            this.btnGözlemciRaporDüzenle.Name = "btnGözlemciRaporDüzenle";
            this.btnGözlemciRaporDüzenle.Size = new System.Drawing.Size(304, 44);
            this.btnGözlemciRaporDüzenle.TabIndex = 49;
            this.btnGözlemciRaporDüzenle.Text = "Rapor Sil";
            this.btnGözlemciRaporDüzenle.UseVisualStyleBackColor = true;
            this.btnGözlemciRaporDüzenle.Click += new System.EventHandler(this.btnGözlemciRaporDüzenle_Click);
            // 
            // cmbTakim2
            // 
            this.cmbTakim2.FormattingEnabled = true;
            this.cmbTakim2.Items.AddRange(new object[] {
            "AkınSpor",
            "Kilimli Bld Spor",
            "Çaydeğirmeni Bld Spor",
            "Alaplı Bld Spor",
            "Mavi Şimşekler Spor",
            "Gelik Spor",
            "Kozlu İhsaniye Spor",
            "ÇaycumaSpor",
            "Krd Ereğli Çiğdemli Spor",
            "Yenimahalle Spor",
            "Elcab Kbl GençlerBirliği Spor",
            "Gülüç Bld Spor",
            "Zonguldak Ereğli Spor",
            "Tersane Spor",
            "Karaman Spor",
            "Güvenlikgücü Spor",
            "Kozlu Taşkömürü Spor",
            "İstasyon Gemiciler Spor",
            "Saltukova Spor",
            "Asma Spor",
            "Terakki Spor"});
            this.cmbTakim2.Location = new System.Drawing.Point(178, 246);
            this.cmbTakim2.Name = "cmbTakim2";
            this.cmbTakim2.Size = new System.Drawing.Size(177, 31);
            this.cmbTakim2.TabIndex = 48;
            // 
            // cmbTakim1
            // 
            this.cmbTakim1.FormattingEnabled = true;
            this.cmbTakim1.Items.AddRange(new object[] {
            "AkınSpor",
            "Kilimli Bld Spor",
            "Çaydeğirmeni Bld Spor",
            "Alaplı Bld Spor",
            "Mavi Şimşekler Spor",
            "Gelik Spor",
            "Kozlu İhsaniye Spor",
            "ÇaycumaSpor",
            "Krd Ereğli Çiğdemli Spor",
            "Yenimahalle Spor",
            "Elcab Kbl GençlerBirliği Spor",
            "Gülüç Bld Spor",
            "Zonguldak Ereğli Spor",
            "Tersane Spor",
            "Karaman Spor",
            "Güvenlikgücü Spor",
            "Kozlu Taşkömürü Spor",
            "İstasyon Gemiciler Spor",
            "Saltukova Spor",
            "Asma Spor",
            "Terakki Spor"});
            this.cmbTakim1.Location = new System.Drawing.Point(178, 198);
            this.cmbTakim1.Name = "cmbTakim1";
            this.cmbTakim1.Size = new System.Drawing.Size(177, 31);
            this.cmbTakim1.TabIndex = 47;
            // 
            // txtMacNo
            // 
            this.txtMacNo.Location = new System.Drawing.Point(177, 100);
            this.txtMacNo.Name = "txtMacNo";
            this.txtMacNo.Size = new System.Drawing.Size(178, 31);
            this.txtMacNo.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Maç Sonucu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Deplasman : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ev Sahibi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Maç No : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(943, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGözlemciRaporSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGözleciIsim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskMacSonuc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGözlemciYorum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHakemIsim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGözlemciRaporDüzenle);
            this.Controls.Add(this.cmbTakim2);
            this.Controls.Add(this.cmbTakim1);
            this.Controls.Add(this.txtMacNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGözlemciRaporSil";
            this.Text = "FrmGözlemciRaporSil";
            this.Load += new System.EventHandler(this.FrmGözlemciRaporSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGözleciIsim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskMacSonuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGözlemciYorum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHakemIsim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGözlemciRaporDüzenle;
        private System.Windows.Forms.ComboBox cmbTakim2;
        private System.Windows.Forms.ComboBox cmbTakim1;
        private System.Windows.Forms.TextBox txtMacNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}