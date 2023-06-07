namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmHakemSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHakemSil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbHakemKlasman = new System.Windows.Forms.ComboBox();
            this.btnHakemDüzenle = new System.Windows.Forms.Button();
            this.mskHakemCepTel = new System.Windows.Forms.MaskedTextBox();
            this.txtHakemLisansNo = new System.Windows.Forms.TextBox();
            this.mskHakemTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtHakemSoyisim = new System.Windows.Forms.TextBox();
            this.txtHakemIsim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 428);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.cmbHakemKlasman.Location = new System.Drawing.Point(235, 263);
            this.cmbHakemKlasman.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHakemKlasman.Name = "cmbHakemKlasman";
            this.cmbHakemKlasman.Size = new System.Drawing.Size(215, 35);
            this.cmbHakemKlasman.TabIndex = 61;
            // 
            // btnHakemDüzenle
            // 
            this.btnHakemDüzenle.Location = new System.Drawing.Point(107, 428);
            this.btnHakemDüzenle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHakemDüzenle.Name = "btnHakemDüzenle";
            this.btnHakemDüzenle.Size = new System.Drawing.Size(343, 41);
            this.btnHakemDüzenle.TabIndex = 59;
            this.btnHakemDüzenle.Text = "Hakem Silme";
            this.btnHakemDüzenle.UseVisualStyleBackColor = true;
            this.btnHakemDüzenle.Click += new System.EventHandler(this.btnHakemDüzenle_Click);
            // 
            // mskHakemCepTel
            // 
            this.mskHakemCepTel.Location = new System.Drawing.Point(235, 388);
            this.mskHakemCepTel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskHakemCepTel.Mask = "(999) 000-0000";
            this.mskHakemCepTel.Name = "mskHakemCepTel";
            this.mskHakemCepTel.Size = new System.Drawing.Size(215, 34);
            this.mskHakemCepTel.TabIndex = 58;
            // 
            // txtHakemLisansNo
            // 
            this.txtHakemLisansNo.Location = new System.Drawing.Point(235, 346);
            this.txtHakemLisansNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHakemLisansNo.Name = "txtHakemLisansNo";
            this.txtHakemLisansNo.Size = new System.Drawing.Size(215, 34);
            this.txtHakemLisansNo.TabIndex = 57;
            // 
            // mskHakemTcNo
            // 
            this.mskHakemTcNo.Location = new System.Drawing.Point(235, 298);
            this.mskHakemTcNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskHakemTcNo.Mask = "00000000000";
            this.mskHakemTcNo.Name = "mskHakemTcNo";
            this.mskHakemTcNo.Size = new System.Drawing.Size(215, 34);
            this.mskHakemTcNo.TabIndex = 56;
            // 
            // txtHakemSoyisim
            // 
            this.txtHakemSoyisim.Location = new System.Drawing.Point(235, 218);
            this.txtHakemSoyisim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHakemSoyisim.Name = "txtHakemSoyisim";
            this.txtHakemSoyisim.Size = new System.Drawing.Size(215, 34);
            this.txtHakemSoyisim.TabIndex = 55;
            // 
            // txtHakemIsim
            // 
            this.txtHakemIsim.Location = new System.Drawing.Point(235, 178);
            this.txtHakemIsim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHakemIsim.Name = "txtHakemIsim";
            this.txtHakemIsim.Size = new System.Drawing.Size(215, 34);
            this.txtHakemIsim.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-6, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 27);
            this.label7.TabIndex = 53;
            this.label7.Text = "Hakem Cep Tel No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 27);
            this.label6.TabIndex = 52;
            this.label6.Text = "Hakem Lisans No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "Hakem Tc No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 27);
            this.label4.TabIndex = 50;
            this.label4.Text = "Hakem Klasmanı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 49;
            this.label3.Text = "Hakem Soyisim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 48;
            this.label2.Text = "Hakem Isim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "HYS - Hakem SİLME Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmHakemSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbHakemKlasman);
            this.Controls.Add(this.btnHakemDüzenle);
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
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHakemSil";
            this.Text = "FrmHakemSil";
            this.Load += new System.EventHandler(this.FrmHakemSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbHakemKlasman;
        private System.Windows.Forms.Button btnHakemDüzenle;
        private System.Windows.Forms.MaskedTextBox mskHakemCepTel;
        private System.Windows.Forms.TextBox txtHakemLisansNo;
        private System.Windows.Forms.MaskedTextBox mskHakemTcNo;
        private System.Windows.Forms.TextBox txtHakemSoyisim;
        private System.Windows.Forms.TextBox txtHakemIsim;
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