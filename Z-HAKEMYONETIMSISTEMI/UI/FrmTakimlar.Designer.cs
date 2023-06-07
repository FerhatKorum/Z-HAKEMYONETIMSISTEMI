namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmTakimlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTakimlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTakimEkle = new System.Windows.Forms.Button();
            this.btnTakimGüncelle = new System.Windows.Forms.Button();
            this.btnTakimSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTakimId = new System.Windows.Forms.TextBox();
            this.txtTakimAdi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(366, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "HYS - TAKIMLAR PANELİ";
            // 
            // btnTakimEkle
            // 
            this.btnTakimEkle.Location = new System.Drawing.Point(388, 281);
            this.btnTakimEkle.Name = "btnTakimEkle";
            this.btnTakimEkle.Size = new System.Drawing.Size(184, 45);
            this.btnTakimEkle.TabIndex = 2;
            this.btnTakimEkle.Text = "Takım Ekle";
            this.btnTakimEkle.UseVisualStyleBackColor = true;
            this.btnTakimEkle.Click += new System.EventHandler(this.btnTakimEkle_Click);
            // 
            // btnTakimGüncelle
            // 
            this.btnTakimGüncelle.Location = new System.Drawing.Point(388, 332);
            this.btnTakimGüncelle.Name = "btnTakimGüncelle";
            this.btnTakimGüncelle.Size = new System.Drawing.Size(184, 45);
            this.btnTakimGüncelle.TabIndex = 3;
            this.btnTakimGüncelle.Text = "Takım Güncelle";
            this.btnTakimGüncelle.UseVisualStyleBackColor = true;
            this.btnTakimGüncelle.Click += new System.EventHandler(this.btnTakimGüncelle_Click);
            // 
            // btnTakimSil
            // 
            this.btnTakimSil.Location = new System.Drawing.Point(388, 383);
            this.btnTakimSil.Name = "btnTakimSil";
            this.btnTakimSil.Size = new System.Drawing.Size(184, 45);
            this.btnTakimSil.TabIndex = 4;
            this.btnTakimSil.Text = "TakımSil";
            this.btnTakimSil.UseVisualStyleBackColor = true;
            this.btnTakimSil.Click += new System.EventHandler(this.btnTakimSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Takim Id : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Takim Adı : ";
            // 
            // txtTakimId
            // 
            this.txtTakimId.Location = new System.Drawing.Point(384, 142);
            this.txtTakimId.Name = "txtTakimId";
            this.txtTakimId.Size = new System.Drawing.Size(190, 31);
            this.txtTakimId.TabIndex = 7;
            // 
            // txtTakimAdi
            // 
            this.txtTakimAdi.Location = new System.Drawing.Point(388, 211);
            this.txtTakimAdi.Name = "txtTakimAdi";
            this.txtTakimAdi.Size = new System.Drawing.Size(190, 31);
            this.txtTakimAdi.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTakimlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTakimAdi);
            this.Controls.Add(this.txtTakimId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTakimSil);
            this.Controls.Add(this.btnTakimGüncelle);
            this.Controls.Add(this.btnTakimEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTakimlar";
            this.Text = "FrmTakimlar";
            this.Load += new System.EventHandler(this.FrmTakimlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTakimEkle;
        private System.Windows.Forms.Button btnTakimGüncelle;
        private System.Windows.Forms.Button btnTakimSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTakimId;
        private System.Windows.Forms.TextBox txtTakimAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}