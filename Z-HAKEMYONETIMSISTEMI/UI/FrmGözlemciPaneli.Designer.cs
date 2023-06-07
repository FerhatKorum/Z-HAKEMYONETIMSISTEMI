namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmGözlemciPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGözlemciPaneli));
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnGözlemciRaporSil = new System.Windows.Forms.Button();
            this.btnGözlemciRaporDüzenle = new System.Windows.Forms.Button();
            this.btnGözlemciRaporEkle = new System.Windows.Forms.Button();
            this.lblGözlemciIsim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "RAPORLAR";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 306);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(898, 158);
            this.dataGridView3.TabIndex = 17;
            // 
            // btnGözlemciRaporSil
            // 
            this.btnGözlemciRaporSil.Location = new System.Drawing.Point(624, 14);
            this.btnGözlemciRaporSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnGözlemciRaporSil.Name = "btnGözlemciRaporSil";
            this.btnGözlemciRaporSil.Size = new System.Drawing.Size(158, 34);
            this.btnGözlemciRaporSil.TabIndex = 14;
            this.btnGözlemciRaporSil.Text = "RaporSil";
            this.btnGözlemciRaporSil.UseVisualStyleBackColor = true;
            this.btnGözlemciRaporSil.Click += new System.EventHandler(this.btnGözlemciRaporSil_Click);
            // 
            // btnGözlemciRaporDüzenle
            // 
            this.btnGözlemciRaporDüzenle.Location = new System.Drawing.Point(462, 14);
            this.btnGözlemciRaporDüzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGözlemciRaporDüzenle.Name = "btnGözlemciRaporDüzenle";
            this.btnGözlemciRaporDüzenle.Size = new System.Drawing.Size(158, 34);
            this.btnGözlemciRaporDüzenle.TabIndex = 13;
            this.btnGözlemciRaporDüzenle.Text = "RaporDüzenle";
            this.btnGözlemciRaporDüzenle.UseVisualStyleBackColor = true;
            this.btnGözlemciRaporDüzenle.Click += new System.EventHandler(this.btnGözlemciRaporDüzenle_Click);
            // 
            // btnGözlemciRaporEkle
            // 
            this.btnGözlemciRaporEkle.Location = new System.Drawing.Point(298, 14);
            this.btnGözlemciRaporEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGözlemciRaporEkle.Name = "btnGözlemciRaporEkle";
            this.btnGözlemciRaporEkle.Size = new System.Drawing.Size(160, 34);
            this.btnGözlemciRaporEkle.TabIndex = 12;
            this.btnGözlemciRaporEkle.Text = "RaporEkle";
            this.btnGözlemciRaporEkle.UseVisualStyleBackColor = true;
            this.btnGözlemciRaporEkle.Click += new System.EventHandler(this.btnGözlemciRaporEkle_Click);
            // 
            // lblGözlemciIsim
            // 
            this.lblGözlemciIsim.AutoSize = true;
            this.lblGözlemciIsim.Location = new System.Drawing.Point(982, 207);
            this.lblGözlemciIsim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGözlemciIsim.Name = "lblGözlemciIsim";
            this.lblGözlemciIsim.Size = new System.Drawing.Size(142, 23);
            this.lblGözlemciIsim.TabIndex = 11;
            this.lblGözlemciIsim.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gözlemci İsim : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(797, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "DUYURULAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 157);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 78);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gözlemci Bilgi";
            // 
            // FrmGözlemciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnGözlemciRaporSil);
            this.Controls.Add(this.btnGözlemciRaporDüzenle);
            this.Controls.Add(this.btnGözlemciRaporEkle);
            this.Controls.Add(this.lblGözlemciIsim);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGözlemciPaneli";
            this.Text = "FrmGözlemciPaneli";
            this.Load += new System.EventHandler(this.FrmGözlemciPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnGözlemciRaporSil;
        private System.Windows.Forms.Button btnGözlemciRaporDüzenle;
        private System.Windows.Forms.Button btnGözlemciRaporEkle;
        private System.Windows.Forms.Label lblGözlemciIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}