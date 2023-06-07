using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Z_HAKEMYONETIMSISTEMI
{
    public partial class FrmHakemEkle : Form
    {
        public FrmHakemEkle()
        {
            InitializeComponent();
        }

        void HakemTemizle()
        {
            txtHakemIsim.Text = "";
            txtHakemSoyisim.Text = "";
            cmbHakemKlasman.Text = "";
            mskHakemTcNo.Text = "";
            txtHakemLisansNo.Text = "";
            mskHakemCepTel.Text = "";
            txtHakemIsim.Focus();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            HakemTemizle();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnHakemEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Hakem(hIsim,hSoyisim,hKlasman,hTcNo,hLisansNo,hCepTel) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtHakemIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtHakemSoyisim.Text);
            komut.Parameters.AddWithValue("@p3", cmbHakemKlasman.Text);
            komut.Parameters.AddWithValue("@p4", mskHakemTcNo.Text);
            komut.Parameters.AddWithValue("@p5", txtHakemLisansNo.Text);
            komut.Parameters.AddWithValue("@p6", mskHakemCepTel.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Hakem Ekleme Islemi Basariyla Gercekestirilmistir.");
        }
    }
}
