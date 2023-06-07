namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmSekreterPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterPaneli));
            this.lblSekreterIsim = new System.Windows.Forms.Label();
            this.lblIsimSoyisim = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHakemSil = new System.Windows.Forms.Button();
            this.btnHakemGüncelle = new System.Windows.Forms.Button();
            this.btnHakemEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGözlemciSil = new System.Windows.Forms.Button();
            this.btnGözlemciGüncelle = new System.Windows.Forms.Button();
            this.btnGözlemciEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDernek = new System.Windows.Forms.Button();
            this.btnILHakemKurulu = new System.Windows.Forms.Button();
            this.btnTakimlar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSekreterIsim
            // 
            this.lblSekreterIsim.AutoSize = true;
            this.lblSekreterIsim.Location = new System.Drawing.Point(1336, 202);
            this.lblSekreterIsim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSekreterIsim.Name = "lblSekreterIsim";
            this.lblSekreterIsim.Size = new System.Drawing.Size(142, 23);
            this.lblSekreterIsim.TabIndex = 3;
            this.lblSekreterIsim.Text = "00000000000";
            // 
            // lblIsimSoyisim
            // 
            this.lblIsimSoyisim.AutoSize = true;
            this.lblIsimSoyisim.Location = new System.Drawing.Point(66, 30);
            this.lblIsimSoyisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsimSoyisim.Name = "lblIsimSoyisim";
            this.lblIsimSoyisim.Size = new System.Drawing.Size(64, 23);
            this.lblIsimSoyisim.TabIndex = 2;
            this.lblIsimSoyisim.Text = "İsim : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHakemSil);
            this.groupBox1.Controls.Add(this.btnHakemGüncelle);
            this.groupBox1.Controls.Add(this.btnHakemEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 245);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hakem Islemleri";
            // 
            // btnHakemSil
            // 
            this.btnHakemSil.Location = new System.Drawing.Point(6, 170);
            this.btnHakemSil.Name = "btnHakemSil";
            this.btnHakemSil.Size = new System.Drawing.Size(208, 42);
            this.btnHakemSil.TabIndex = 2;
            this.btnHakemSil.Text = "HakemSil";
            this.btnHakemSil.UseVisualStyleBackColor = true;
            this.btnHakemSil.Click += new System.EventHandler(this.btnHakemSil_Click);
            // 
            // btnHakemGüncelle
            // 
            this.btnHakemGüncelle.Location = new System.Drawing.Point(6, 109);
            this.btnHakemGüncelle.Name = "btnHakemGüncelle";
            this.btnHakemGüncelle.Size = new System.Drawing.Size(208, 42);
            this.btnHakemGüncelle.TabIndex = 1;
            this.btnHakemGüncelle.Text = "Hakem Güncelle";
            this.btnHakemGüncelle.UseVisualStyleBackColor = true;
            this.btnHakemGüncelle.Click += new System.EventHandler(this.btnHakemGüncelle_Click);
            // 
            // btnHakemEkle
            // 
            this.btnHakemEkle.Location = new System.Drawing.Point(6, 60);
            this.btnHakemEkle.Name = "btnHakemEkle";
            this.btnHakemEkle.Size = new System.Drawing.Size(208, 43);
            this.btnHakemEkle.TabIndex = 0;
            this.btnHakemEkle.Text = "HakemEkle";
            this.btnHakemEkle.UseVisualStyleBackColor = true;
            this.btnHakemEkle.Click += new System.EventHandler(this.btnHakemEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGözlemciSil);
            this.groupBox2.Controls.Add(this.btnGözlemciGüncelle);
            this.groupBox2.Controls.Add(this.btnGözlemciEkle);
            this.groupBox2.Location = new System.Drawing.Point(12, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 245);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gözlemci Islemleri";
            // 
            // btnGözlemciSil
            // 
            this.btnGözlemciSil.Location = new System.Drawing.Point(6, 170);
            this.btnGözlemciSil.Name = "btnGözlemciSil";
            this.btnGözlemciSil.Size = new System.Drawing.Size(208, 42);
            this.btnGözlemciSil.TabIndex = 5;
            this.btnGözlemciSil.Text = "Gözlemci Sil";
            this.btnGözlemciSil.UseVisualStyleBackColor = true;
            this.btnGözlemciSil.Click += new System.EventHandler(this.btnGözlemciSil_Click);
            // 
            // btnGözlemciGüncelle
            // 
            this.btnGözlemciGüncelle.Location = new System.Drawing.Point(6, 109);
            this.btnGözlemciGüncelle.Name = "btnGözlemciGüncelle";
            this.btnGözlemciGüncelle.Size = new System.Drawing.Size(208, 42);
            this.btnGözlemciGüncelle.TabIndex = 4;
            this.btnGözlemciGüncelle.Text = "Gözlemci Güncelle";
            this.btnGözlemciGüncelle.UseVisualStyleBackColor = true;
            this.btnGözlemciGüncelle.Click += new System.EventHandler(this.btnGözlemciGüncelle_Click);
            // 
            // btnGözlemciEkle
            // 
            this.btnGözlemciEkle.Location = new System.Drawing.Point(6, 48);
            this.btnGözlemciEkle.Name = "btnGözlemciEkle";
            this.btnGözlemciEkle.Size = new System.Drawing.Size(208, 43);
            this.btnGözlemciEkle.TabIndex = 3;
            this.btnGözlemciEkle.Text = "Gözlemci Ekle";
            this.btnGözlemciEkle.UseVisualStyleBackColor = true;
            this.btnGözlemciEkle.Click += new System.EventHandler(this.btnGözlemciEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(971, 210);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(238, 346);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(971, 233);
            this.dataGridView2.TabIndex = 7;
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(6, 30);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(185, 37);
            this.btnDuyuruOlustur.TabIndex = 8;
            this.btnDuyuruOlustur.Text = "Duyuru Paneli";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDernek);
            this.groupBox3.Controls.Add(this.btnILHakemKurulu);
            this.groupBox3.Controls.Add(this.btnTakimlar);
            this.groupBox3.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox3.Location = new System.Drawing.Point(313, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 93);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diğer Islemler";
            // 
            // btnDernek
            // 
            this.btnDernek.Location = new System.Drawing.Point(579, 30);
            this.btnDernek.Name = "btnDernek";
            this.btnDernek.Size = new System.Drawing.Size(185, 37);
            this.btnDernek.TabIndex = 11;
            this.btnDernek.Text = "Dernek";
            this.btnDernek.UseVisualStyleBackColor = true;
            this.btnDernek.Click += new System.EventHandler(this.btnDernek_Click);
            // 
            // btnILHakemKurulu
            // 
            this.btnILHakemKurulu.Location = new System.Drawing.Point(388, 30);
            this.btnILHakemKurulu.Name = "btnILHakemKurulu";
            this.btnILHakemKurulu.Size = new System.Drawing.Size(185, 37);
            this.btnILHakemKurulu.TabIndex = 10;
            this.btnILHakemKurulu.Text = "IL Hakem Kurulu";
            this.btnILHakemKurulu.UseVisualStyleBackColor = true;
            this.btnILHakemKurulu.Click += new System.EventHandler(this.btnILHakemKurulu_Click);
            // 
            // btnTakimlar
            // 
            this.btnTakimlar.Location = new System.Drawing.Point(197, 30);
            this.btnTakimlar.Name = "btnTakimlar";
            this.btnTakimlar.Size = new System.Drawing.Size(185, 37);
            this.btnTakimlar.TabIndex = 9;
            this.btnTakimlar.Text = "Takım Paneli";
            this.btnTakimlar.UseVisualStyleBackColor = true;
            this.btnTakimlar.Click += new System.EventHandler(this.btnTakimlar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblIsimSoyisim);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 67);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sekreter Bilgi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1093, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSekreterPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 595);
            this.Controls.Add(this.lblSekreterIsim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSekreterPaneli";
            this.Text = "FrmSekreterPaneli";
            this.Load += new System.EventHandler(this.FrmSekreterPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSekreterIsim;
        private System.Windows.Forms.Label lblIsimSoyisim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHakemSil;
        private System.Windows.Forms.Button btnHakemGüncelle;
        private System.Windows.Forms.Button btnHakemEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGözlemciSil;
        private System.Windows.Forms.Button btnGözlemciGüncelle;
        private System.Windows.Forms.Button btnGözlemciEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDernek;
        private System.Windows.Forms.Button btnILHakemKurulu;
        private System.Windows.Forms.Button btnTakimlar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}