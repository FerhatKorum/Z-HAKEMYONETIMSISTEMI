namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmGözlemciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGözlemciEkle));
            this.cmbGözlemciKlasman = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGözlemciEkle = new System.Windows.Forms.Button();
            this.mskGözlemciCepTel = new System.Windows.Forms.MaskedTextBox();
            this.txtGözlemciLisansNo = new System.Windows.Forms.TextBox();
            this.mskGözlemciTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtGözlemciSoyisim = new System.Windows.Forms.TextBox();
            this.txtGözlemciIsim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGözlemciKlasman
            // 
            this.cmbGözlemciKlasman.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGözlemciKlasman.FormattingEnabled = true;
            this.cmbGözlemciKlasman.Items.AddRange(new object[] {
            "İl Gözlemcisi",
            "Bölgesel  Gözlemcisi",
            "C Klasman Gözlemcisi",
            "B Klasman Gözlemcisi",
            "A Klasman Gözlemcisi",
            "Süper Lig Gözlemcisi"});
            this.cmbGözlemciKlasman.Location = new System.Drawing.Point(270, 192);
            this.cmbGözlemciKlasman.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGözlemciKlasman.Name = "cmbGözlemciKlasman";
            this.cmbGözlemciKlasman.Size = new System.Drawing.Size(235, 35);
            this.cmbGözlemciKlasman.TabIndex = 45;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(189, 354);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(109, 37);
            this.btnTemizle.TabIndex = 44;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGözlemciEkle
            // 
            this.btnGözlemciEkle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGözlemciEkle.Location = new System.Drawing.Point(302, 354);
            this.btnGözlemciEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGözlemciEkle.Name = "btnGözlemciEkle";
            this.btnGözlemciEkle.Size = new System.Drawing.Size(201, 37);
            this.btnGözlemciEkle.TabIndex = 43;
            this.btnGözlemciEkle.Text = "Gözlemci Ekle";
            this.btnGözlemciEkle.UseVisualStyleBackColor = true;
            this.btnGözlemciEkle.Click += new System.EventHandler(this.btnGözlemciEkle_Click);
            // 
            // mskGözlemciCepTel
            // 
            this.mskGözlemciCepTel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskGözlemciCepTel.Location = new System.Drawing.Point(270, 299);
            this.mskGözlemciCepTel.Margin = new System.Windows.Forms.Padding(2);
            this.mskGözlemciCepTel.Mask = "(999) 000-0000";
            this.mskGözlemciCepTel.Name = "mskGözlemciCepTel";
            this.mskGözlemciCepTel.Size = new System.Drawing.Size(235, 34);
            this.mskGözlemciCepTel.TabIndex = 42;
            // 
            // txtGözlemciLisansNo
            // 
            this.txtGözlemciLisansNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGözlemciLisansNo.Location = new System.Drawing.Point(270, 261);
            this.txtGözlemciLisansNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtGözlemciLisansNo.Name = "txtGözlemciLisansNo";
            this.txtGözlemciLisansNo.Size = new System.Drawing.Size(235, 34);
            this.txtGözlemciLisansNo.TabIndex = 41;
            // 
            // mskGözlemciTcNo
            // 
            this.mskGözlemciTcNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskGözlemciTcNo.Location = new System.Drawing.Point(270, 226);
            this.mskGözlemciTcNo.Margin = new System.Windows.Forms.Padding(2);
            this.mskGözlemciTcNo.Mask = "00000000000";
            this.mskGözlemciTcNo.Name = "mskGözlemciTcNo";
            this.mskGözlemciTcNo.Size = new System.Drawing.Size(235, 34);
            this.mskGözlemciTcNo.TabIndex = 40;
            // 
            // txtGözlemciSoyisim
            // 
            this.txtGözlemciSoyisim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGözlemciSoyisim.Location = new System.Drawing.Point(270, 154);
            this.txtGözlemciSoyisim.Margin = new System.Windows.Forms.Padding(2);
            this.txtGözlemciSoyisim.Name = "txtGözlemciSoyisim";
            this.txtGözlemciSoyisim.Size = new System.Drawing.Size(235, 34);
            this.txtGözlemciSoyisim.TabIndex = 39;
            // 
            // txtGözlemciIsim
            // 
            this.txtGözlemciIsim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGözlemciIsim.Location = new System.Drawing.Point(270, 113);
            this.txtGözlemciIsim.Margin = new System.Windows.Forms.Padding(2);
            this.txtGözlemciIsim.Name = "txtGözlemciIsim";
            this.txtGözlemciIsim.Size = new System.Drawing.Size(235, 34);
            this.txtGözlemciIsim.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "Gözlemci Cep Tel No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = "Gözlemci Lisans No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "Gözlemci TC No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "Gözlemci Klasmanı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "Gözlemci Soyisim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Gözlemci Isim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "HYS - Gözlemci Ekleme Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGözlemciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbGözlemciKlasman);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGözlemciEkle);
            this.Controls.Add(this.mskGözlemciCepTel);
            this.Controls.Add(this.txtGözlemciLisansNo);
            this.Controls.Add(this.mskGözlemciTcNo);
            this.Controls.Add(this.txtGözlemciSoyisim);
            this.Controls.Add(this.txtGözlemciIsim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGözlemciEkle";
            this.Text = "FrmGözlemciEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGözlemciKlasman;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGözlemciEkle;
        private System.Windows.Forms.MaskedTextBox mskGözlemciCepTel;
        private System.Windows.Forms.TextBox txtGözlemciLisansNo;
        private System.Windows.Forms.MaskedTextBox mskGözlemciTcNo;
        private System.Windows.Forms.TextBox txtGözlemciSoyisim;
        private System.Windows.Forms.TextBox txtGözlemciIsim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}