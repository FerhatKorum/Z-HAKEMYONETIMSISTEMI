namespace Z_HAKEMYONETIMSISTEMI
{
    partial class FrmHakemGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHakemGiriş));
            this.btnHakemGirisYap = new System.Windows.Forms.Button();
            this.txtHakemTC = new System.Windows.Forms.TextBox();
            this.txtHakemIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHakemGirisYap
            // 
            this.btnHakemGirisYap.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnHakemGirisYap.Location = new System.Drawing.Point(377, 210);
            this.btnHakemGirisYap.Name = "btnHakemGirisYap";
            this.btnHakemGirisYap.Size = new System.Drawing.Size(126, 37);
            this.btnHakemGirisYap.TabIndex = 20;
            this.btnHakemGirisYap.Text = "Giris Yap";
            this.btnHakemGirisYap.UseVisualStyleBackColor = true;
            this.btnHakemGirisYap.Click += new System.EventHandler(this.btnHakemGirisYap_Click);
            // 
            // txtHakemTC
            // 
            this.txtHakemTC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHakemTC.Location = new System.Drawing.Point(289, 170);
            this.txtHakemTC.Name = "txtHakemTC";
            this.txtHakemTC.Size = new System.Drawing.Size(214, 34);
            this.txtHakemTC.TabIndex = 19;
            this.txtHakemTC.Text = "11111111111";
            this.txtHakemTC.UseSystemPasswordChar = true;
            // 
            // txtHakemIsim
            // 
            this.txtHakemIsim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHakemIsim.Location = new System.Drawing.Point(289, 125);
            this.txtHakemIsim.Name = "txtHakemIsim";
            this.txtHakemIsim.Size = new System.Drawing.Size(214, 34);
            this.txtHakemIsim.TabIndex = 18;
            this.txtHakemIsim.Text = "Ferhat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "TC : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "İsim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "HYS - Hakem PANELİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(582, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHakemGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHakemGirisYap);
            this.Controls.Add(this.txtHakemTC);
            this.Controls.Add(this.txtHakemIsim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHakemGiriş";
            this.Text = "FrmHakemGiriş";
//            this.Load += new System.EventHandler(this.FrmHakemGiriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHakemGirisYap;
        private System.Windows.Forms.TextBox txtHakemTC;
        private System.Windows.Forms.TextBox txtHakemIsim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}