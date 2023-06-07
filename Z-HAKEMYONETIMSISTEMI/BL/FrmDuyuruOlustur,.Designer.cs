namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmDuyuruOlustur_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyuruOlustur_));
            this.label1 = new System.Windows.Forms.Label();
            this.rchDuyuruOlustur = new System.Windows.Forms.RichTextBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "HYS - Duyuru Olusturma Paneli";
            // 
            // rchDuyuruOlustur
            // 
            this.rchDuyuruOlustur.Location = new System.Drawing.Point(15, 110);
            this.rchDuyuruOlustur.Margin = new System.Windows.Forms.Padding(6);
            this.rchDuyuruOlustur.Name = "rchDuyuruOlustur";
            this.rchDuyuruOlustur.Size = new System.Drawing.Size(697, 330);
            this.rchDuyuruOlustur.TabIndex = 18;
            this.rchDuyuruOlustur.Text = "";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(245, 452);
            this.btnDuyuruOlustur.Margin = new System.Windows.Forms.Padding(6);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(257, 47);
            this.btnDuyuruOlustur.TabIndex = 19;
            this.btnDuyuruOlustur.Text = "Duyuru Olustur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(610, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDuyuruOlustur_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDuyuruOlustur);
            this.Controls.Add(this.rchDuyuruOlustur);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmDuyuruOlustur_";
            this.Text = "FrmDuyuruOlustur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchDuyuruOlustur;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}