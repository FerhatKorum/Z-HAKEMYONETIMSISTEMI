namespace Z_HAKEMYONETIMSISTEMI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHakemGiris = new System.Windows.Forms.Button();
            this.btnSekreterGiris = new System.Windows.Forms.Button();
            this.btnGözlemciGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 422);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "**Giriş için resimleri kullanınız";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "ZONGULDAK HAKEM YÖNETİM SİSTEMİ";
            // 
            // BtnHakemGiris
            // 
            this.BtnHakemGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHakemGiris.BackgroundImage")));
            this.BtnHakemGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHakemGiris.Location = new System.Drawing.Point(52, 110);
            this.BtnHakemGiris.Name = "BtnHakemGiris";
            this.BtnHakemGiris.Size = new System.Drawing.Size(299, 241);
            this.BtnHakemGiris.TabIndex = 12;
            this.BtnHakemGiris.UseVisualStyleBackColor = true;
            this.BtnHakemGiris.Click += new System.EventHandler(this.BtnHakemGiris_Click);
            // 
            // btnSekreterGiris
            // 
            this.btnSekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterGiris.BackgroundImage")));
            this.btnSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterGiris.Location = new System.Drawing.Point(357, 110);
            this.btnSekreterGiris.Name = "btnSekreterGiris";
            this.btnSekreterGiris.Size = new System.Drawing.Size(299, 241);
            this.btnSekreterGiris.TabIndex = 13;
            this.btnSekreterGiris.UseVisualStyleBackColor = true;
            this.btnSekreterGiris.Click += new System.EventHandler(this.btnSekreterGiris_Click);
            // 
            // btnGözlemciGiris
            // 
            this.btnGözlemciGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGözlemciGiris.BackgroundImage")));
            this.btnGözlemciGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGözlemciGiris.Location = new System.Drawing.Point(662, 110);
            this.btnGözlemciGiris.Name = "btnGözlemciGiris";
            this.btnGözlemciGiris.Size = new System.Drawing.Size(299, 241);
            this.btnGözlemciGiris.TabIndex = 14;
            this.btnGözlemciGiris.Text = "button3";
            this.btnGözlemciGiris.UseVisualStyleBackColor = true;
            this.btnGözlemciGiris.Click += new System.EventHandler(this.btnGözlemciGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label3.Location = new System.Drawing.Point(145, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "HAKEM ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label4.Location = new System.Drawing.Point(425, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "SEKRETER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label5.Location = new System.Drawing.Point(729, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "GÖZLEMCİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(905, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1033, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGözlemciGiris);
            this.Controls.Add(this.btnSekreterGiris);
            this.Controls.Add(this.BtnHakemGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kullanıcı Giriş Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHakemGiris;
        private System.Windows.Forms.Button btnSekreterGiris;
        private System.Windows.Forms.Button btnGözlemciGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

