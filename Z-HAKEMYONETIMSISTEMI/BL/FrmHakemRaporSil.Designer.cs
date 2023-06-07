namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmHakemRaporSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHakemRaporSil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtHakemIsim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnHakemRaporSil = new System.Windows.Forms.Button();
            this.txtMacSonuc = new System.Windows.Forms.TextBox();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 372);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtHakemIsim
            // 
            this.txtHakemIsim.Location = new System.Drawing.Point(165, 173);
            this.txtHakemIsim.Name = "txtHakemIsim";
            this.txtHakemIsim.Size = new System.Drawing.Size(178, 31);
            this.txtHakemIsim.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Hakem Isim : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "HAKEM RAPOR SİLME PANELİ";
            // 
            // BtnHakemRaporSil
            // 
            this.BtnHakemRaporSil.Location = new System.Drawing.Point(64, 399);
            this.BtnHakemRaporSil.Name = "BtnHakemRaporSil";
            this.BtnHakemRaporSil.Size = new System.Drawing.Size(262, 44);
            this.BtnHakemRaporSil.TabIndex = 31;
            this.BtnHakemRaporSil.Text = "Rapor Sil";
            this.BtnHakemRaporSil.UseVisualStyleBackColor = true;
            this.BtnHakemRaporSil.Click += new System.EventHandler(this.BtnHakemRaporSil_Click);
            // 
            // txtMacSonuc
            // 
            this.txtMacSonuc.Location = new System.Drawing.Point(166, 329);
            this.txtMacSonuc.Name = "txtMacSonuc";
            this.txtMacSonuc.Size = new System.Drawing.Size(178, 31);
            this.txtMacSonuc.TabIndex = 30;
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
            this.cmbTakim2.Location = new System.Drawing.Point(166, 275);
            this.cmbTakim2.Name = "cmbTakim2";
            this.cmbTakim2.Size = new System.Drawing.Size(177, 31);
            this.cmbTakim2.TabIndex = 29;
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
            this.cmbTakim1.Location = new System.Drawing.Point(166, 227);
            this.cmbTakim1.Name = "cmbTakim1";
            this.cmbTakim1.Size = new System.Drawing.Size(177, 31);
            this.cmbTakim1.TabIndex = 28;
            // 
            // txtMacNo
            // 
            this.txtMacNo.Location = new System.Drawing.Point(165, 120);
            this.txtMacNo.Name = "txtMacNo";
            this.txtMacNo.Size = new System.Drawing.Size(178, 31);
            this.txtMacNo.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Maç Sonucu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Deplasman : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ev Sahibi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Maç No : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(966, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHakemRaporSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHakemIsim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnHakemRaporSil);
            this.Controls.Add(this.txtMacSonuc);
            this.Controls.Add(this.cmbTakim2);
            this.Controls.Add(this.cmbTakim1);
            this.Controls.Add(this.txtMacNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHakemRaporSil";
            this.Text = "FrmHakemRaporSil";
            this.Load += new System.EventHandler(this.FrmHakemRaporSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtHakemIsim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnHakemRaporSil;
        private System.Windows.Forms.TextBox txtMacSonuc;
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