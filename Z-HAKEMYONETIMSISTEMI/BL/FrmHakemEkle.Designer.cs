namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmHakemEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHakemEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHakemIsim = new System.Windows.Forms.TextBox();
            this.txtHakemSoyisim = new System.Windows.Forms.TextBox();
            this.mskHakemTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtHakemLisansNo = new System.Windows.Forms.TextBox();
            this.mskHakemCepTel = new System.Windows.Forms.MaskedTextBox();
            this.btnHakemEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.cmbHakemKlasman = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "HYS - Hakem Ekleme Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hakem Isim : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hakem Soyisim : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hakem Klasmanı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hakem Tc No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Hakem Lisans No : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hakem Cep Tel No : ";
            // 
            // txtHakemIsim
            // 
            this.txtHakemIsim.Location = new System.Drawing.Point(255, 124);
            this.txtHakemIsim.Name = "txtHakemIsim";
            this.txtHakemIsim.Size = new System.Drawing.Size(185, 31);
            this.txtHakemIsim.TabIndex = 23;
            // 
            // txtHakemSoyisim
            // 
            this.txtHakemSoyisim.Location = new System.Drawing.Point(255, 174);
            this.txtHakemSoyisim.Name = "txtHakemSoyisim";
            this.txtHakemSoyisim.Size = new System.Drawing.Size(185, 31);
            this.txtHakemSoyisim.TabIndex = 24;
            // 
            // mskHakemTcNo
            // 
            this.mskHakemTcNo.Location = new System.Drawing.Point(255, 269);
            this.mskHakemTcNo.Mask = "00000000000";
            this.mskHakemTcNo.Name = "mskHakemTcNo";
            this.mskHakemTcNo.Size = new System.Drawing.Size(185, 31);
            this.mskHakemTcNo.TabIndex = 25;
            // 
            // txtHakemLisansNo
            // 
            this.txtHakemLisansNo.Location = new System.Drawing.Point(255, 325);
            this.txtHakemLisansNo.Name = "txtHakemLisansNo";
            this.txtHakemLisansNo.Size = new System.Drawing.Size(185, 31);
            this.txtHakemLisansNo.TabIndex = 26;
            // 
            // mskHakemCepTel
            // 
            this.mskHakemCepTel.Location = new System.Drawing.Point(255, 375);
            this.mskHakemCepTel.Mask = "(999) 000-0000";
            this.mskHakemCepTel.Name = "mskHakemCepTel";
            this.mskHakemCepTel.Size = new System.Drawing.Size(185, 31);
            this.mskHakemCepTel.TabIndex = 27;
            // 
            // btnHakemEkle
            // 
            this.btnHakemEkle.Location = new System.Drawing.Point(294, 412);
            this.btnHakemEkle.Name = "btnHakemEkle";
            this.btnHakemEkle.Size = new System.Drawing.Size(155, 39);
            this.btnHakemEkle.TabIndex = 28;
            this.btnHakemEkle.Text = "Hakem Ekle";
            this.btnHakemEkle.UseVisualStyleBackColor = true;
            this.btnHakemEkle.Click += new System.EventHandler(this.btnHakemEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(133, 416);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(155, 35);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // cmbHakemKlasman
            // 
            this.cmbHakemKlasman.FormattingEnabled = true;
            this.cmbHakemKlasman.Items.AddRange(new object[] {
            "Aday",
            "İl Hakemi",
            "Bölgesel Hakem",
            "Bölgesel Yrd Hakem",
            "C Klasman Hakemi",
            "C Klasman Yrd Hakemi",
            "B Klasman Hakemi",
            "B Klasman Yrd Hakemi",
            "A Klasman Hakemi ",
            "A Klasman Yrd Hakemi",
            "Süper Lig Hakemi",
            "Süper Lig Yrd Hakemi ",
            "VAR Hakemi",
            "AVAR Hakemi"});
            this.cmbHakemKlasman.Location = new System.Drawing.Point(255, 227);
            this.cmbHakemKlasman.Name = "cmbHakemKlasman";
            this.cmbHakemKlasman.Size = new System.Drawing.Size(185, 31);
            this.cmbHakemKlasman.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHakemEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbHakemKlasman);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHakemEkle);
            this.Controls.Add(this.mskHakemCepTel);
            this.Controls.Add(this.txtHakemLisansNo);
            this.Controls.Add(this.mskHakemTcNo);
            this.Controls.Add(this.txtHakemSoyisim);
            this.Controls.Add(this.txtHakemIsim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHakemEkle";
            this.Text = "FrmHakemEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHakemIsim;
        private System.Windows.Forms.TextBox txtHakemSoyisim;
        private System.Windows.Forms.MaskedTextBox mskHakemTcNo;
        private System.Windows.Forms.TextBox txtHakemLisansNo;
        private System.Windows.Forms.MaskedTextBox mskHakemCepTel;
        private System.Windows.Forms.Button btnHakemEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ComboBox cmbHakemKlasman;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}