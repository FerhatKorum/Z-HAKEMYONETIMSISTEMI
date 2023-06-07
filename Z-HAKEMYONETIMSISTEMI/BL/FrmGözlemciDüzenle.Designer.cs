namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmGözlemciDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGözlemciDüzenle));
            this.cmbGözlemciKlasman = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGözlemciDüzenle = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGözlemciKlasman
            // 
            this.cmbGözlemciKlasman.FormattingEnabled = true;
            this.cmbGözlemciKlasman.Items.AddRange(new object[] {
            "İl Gözlemcisi",
            "Bölgesel  Gözlemcisi",
            "C Klasman Gözlemcisi",
            "B Klasman Gözlemcisi",
            "A Klasman Gözlemcisi",
            "Süper Lig Gözlemcisi"});
            this.cmbGözlemciKlasman.Location = new System.Drawing.Point(344, 209);
            this.cmbGözlemciKlasman.Name = "cmbGözlemciKlasman";
            this.cmbGözlemciKlasman.Size = new System.Drawing.Size(221, 40);
            this.cmbGözlemciKlasman.TabIndex = 60;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(110, 413);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(167, 39);
            this.btnTemizle.TabIndex = 59;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGözlemciDüzenle
            // 
            this.btnGözlemciDüzenle.Location = new System.Drawing.Point(279, 413);
            this.btnGözlemciDüzenle.Name = "btnGözlemciDüzenle";
            this.btnGözlemciDüzenle.Size = new System.Drawing.Size(286, 39);
            this.btnGözlemciDüzenle.TabIndex = 58;
            this.btnGözlemciDüzenle.Text = "Gözlemci Düzenle";
            this.btnGözlemciDüzenle.UseVisualStyleBackColor = true;
            this.btnGözlemciDüzenle.Click += new System.EventHandler(this.btnGözlemciDüzenle_Click);
            // 
            // mskGözlemciCepTel
            // 
            this.mskGözlemciCepTel.Location = new System.Drawing.Point(344, 357);
            this.mskGözlemciCepTel.Mask = "(999) 000-0000";
            this.mskGözlemciCepTel.Name = "mskGözlemciCepTel";
            this.mskGözlemciCepTel.Size = new System.Drawing.Size(221, 39);
            this.mskGözlemciCepTel.TabIndex = 57;
            // 
            // txtGözlemciLisansNo
            // 
            this.txtGözlemciLisansNo.Location = new System.Drawing.Point(344, 307);
            this.txtGözlemciLisansNo.Name = "txtGözlemciLisansNo";
            this.txtGözlemciLisansNo.Size = new System.Drawing.Size(221, 39);
            this.txtGözlemciLisansNo.TabIndex = 56;
            // 
            // mskGözlemciTcNo
            // 
            this.mskGözlemciTcNo.Location = new System.Drawing.Point(344, 251);
            this.mskGözlemciTcNo.Mask = "00000000000";
            this.mskGözlemciTcNo.Name = "mskGözlemciTcNo";
            this.mskGözlemciTcNo.Size = new System.Drawing.Size(221, 39);
            this.mskGözlemciTcNo.TabIndex = 55;
            // 
            // txtGözlemciSoyisim
            // 
            this.txtGözlemciSoyisim.Location = new System.Drawing.Point(344, 156);
            this.txtGözlemciSoyisim.Name = "txtGözlemciSoyisim";
            this.txtGözlemciSoyisim.Size = new System.Drawing.Size(221, 39);
            this.txtGözlemciSoyisim.TabIndex = 54;
            // 
            // txtGözlemciIsim
            // 
            this.txtGözlemciIsim.Location = new System.Drawing.Point(344, 106);
            this.txtGözlemciIsim.Name = "txtGözlemciIsim";
            this.txtGözlemciIsim.Size = new System.Drawing.Size(221, 39);
            this.txtGözlemciIsim.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 32);
            this.label7.TabIndex = 52;
            this.label7.Text = "Gözlemci Cep Tel No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 32);
            this.label6.TabIndex = 51;
            this.label6.Text = "Gözlemci Lisans No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 32);
            this.label5.TabIndex = 50;
            this.label5.Text = "Gözlemci Tc No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "Gözlemci Klasmanı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 32);
            this.label3.TabIndex = 48;
            this.label3.Text = "Gözlemci Soyisim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 32);
            this.label2.TabIndex = 47;
            this.label2.Text = "Gözlemci Isim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "HYS - Gözlemci Düzenleme Paneli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(571, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 343);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1135, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGözlemciDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbGözlemciKlasman);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGözlemciDüzenle);
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
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmGözlemciDüzenle";
            this.Text = "FrmGözlemciDüzenle";
            this.Load += new System.EventHandler(this.FrmGözlemciDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGözlemciKlasman;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGözlemciDüzenle;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}