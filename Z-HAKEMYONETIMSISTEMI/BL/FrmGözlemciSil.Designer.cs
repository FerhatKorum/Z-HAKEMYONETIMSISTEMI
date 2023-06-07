namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmGözlemciSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGözlemciSil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbGözlemciKlasman = new System.Windows.Forms.ComboBox();
            this.btnGözlemciSil = new System.Windows.Forms.Button();
            this.mskGözlemciCepTel = new System.Windows.Forms.MaskedTextBox();
            this.txtGözlemciLisansNo = new System.Windows.Forms.TextBox();
            this.mskGözlemciTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtGözlemciSoyisim = new System.Windows.Forms.TextBox();
            this.txtGözlemciIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(488, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 428);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.cmbGözlemciKlasman.Location = new System.Drawing.Point(268, 236);
            this.cmbGözlemciKlasman.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbGözlemciKlasman.Name = "cmbGözlemciKlasman";
            this.cmbGözlemciKlasman.Size = new System.Drawing.Size(215, 35);
            this.cmbGözlemciKlasman.TabIndex = 76;
            // 
            // btnGözlemciSil
            // 
            this.btnGözlemciSil.Location = new System.Drawing.Point(140, 401);
            this.btnGözlemciSil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGözlemciSil.Name = "btnGözlemciSil";
            this.btnGözlemciSil.Size = new System.Drawing.Size(343, 41);
            this.btnGözlemciSil.TabIndex = 75;
            this.btnGözlemciSil.Text = "Gözlemci Silme";
            this.btnGözlemciSil.UseVisualStyleBackColor = true;
            this.btnGözlemciSil.Click += new System.EventHandler(this.btnGözlemciSil_Click);
            // 
            // mskGözlemciCepTel
            // 
            this.mskGözlemciCepTel.Location = new System.Drawing.Point(268, 361);
            this.mskGözlemciCepTel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskGözlemciCepTel.Mask = "(999) 000-0000";
            this.mskGözlemciCepTel.Name = "mskGözlemciCepTel";
            this.mskGözlemciCepTel.Size = new System.Drawing.Size(215, 34);
            this.mskGözlemciCepTel.TabIndex = 74;
            // 
            // txtGözlemciLisansNo
            // 
            this.txtGözlemciLisansNo.Location = new System.Drawing.Point(268, 319);
            this.txtGözlemciLisansNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGözlemciLisansNo.Name = "txtGözlemciLisansNo";
            this.txtGözlemciLisansNo.Size = new System.Drawing.Size(215, 34);
            this.txtGözlemciLisansNo.TabIndex = 73;
            // 
            // mskGözlemciTcNo
            // 
            this.mskGözlemciTcNo.Location = new System.Drawing.Point(268, 275);
            this.mskGözlemciTcNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskGözlemciTcNo.Mask = "00000000000";
            this.mskGözlemciTcNo.Name = "mskGözlemciTcNo";
            this.mskGözlemciTcNo.Size = new System.Drawing.Size(215, 34);
            this.mskGözlemciTcNo.TabIndex = 72;
            // 
            // txtGözlemciSoyisim
            // 
            this.txtGözlemciSoyisim.Location = new System.Drawing.Point(268, 191);
            this.txtGözlemciSoyisim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGözlemciSoyisim.Name = "txtGözlemciSoyisim";
            this.txtGözlemciSoyisim.Size = new System.Drawing.Size(215, 34);
            this.txtGözlemciSoyisim.TabIndex = 71;
            // 
            // txtGözlemciIsim
            // 
            this.txtGözlemciIsim.Location = new System.Drawing.Point(268, 151);
            this.txtGözlemciIsim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGözlemciIsim.Name = "txtGözlemciIsim";
            this.txtGözlemciIsim.Size = new System.Drawing.Size(215, 34);
            this.txtGözlemciIsim.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "HYS - Gözlemci SİLME Paneli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 27);
            this.label7.TabIndex = 83;
            this.label7.Text = "Gözlemci Cep Tel No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 27);
            this.label6.TabIndex = 82;
            this.label6.Text = "Gözlemci Lisans No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 27);
            this.label5.TabIndex = 81;
            this.label5.Text = "Gözlemci TC No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 27);
            this.label4.TabIndex = 80;
            this.label4.Text = "Gözlemci Klasmanı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 27);
            this.label3.TabIndex = 79;
            this.label3.Text = "Gözlemci Soyisim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 78;
            this.label2.Text = "Gözlemci Isim : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1123, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGözlemciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbGözlemciKlasman);
            this.Controls.Add(this.btnGözlemciSil);
            this.Controls.Add(this.mskGözlemciCepTel);
            this.Controls.Add(this.txtGözlemciLisansNo);
            this.Controls.Add(this.mskGözlemciTcNo);
            this.Controls.Add(this.txtGözlemciSoyisim);
            this.Controls.Add(this.txtGözlemciIsim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmGözlemciSil";
            this.Text = "FrmGözlemciSil";
            this.Load += new System.EventHandler(this.FrmGözlemciSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbGözlemciKlasman;
        private System.Windows.Forms.Button btnGözlemciSil;
        private System.Windows.Forms.MaskedTextBox mskGözlemciCepTel;
        private System.Windows.Forms.TextBox txtGözlemciLisansNo;
        private System.Windows.Forms.MaskedTextBox mskGözlemciTcNo;
        private System.Windows.Forms.TextBox txtGözlemciSoyisim;
        private System.Windows.Forms.TextBox txtGözlemciIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}