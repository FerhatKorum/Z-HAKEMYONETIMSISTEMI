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
    public partial class FrmGözlemciEkle : Form
    {
        public FrmGözlemciEkle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGözlemciEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Gözlemci(gIsim,gSoyisim,gKlasman,gTcNo,gLisansNo,gCepTel) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtGözlemciIsim.Text);
            komut.Parameters.AddWithValue("@p2", txtGözlemciSoyisim.Text);
            komut.Parameters.AddWithValue("@p3", cmbGözlemciKlasman.Text);
            komut.Parameters.AddWithValue("@p4", mskGözlemciTcNo.Text);
            komut.Parameters.AddWithValue("@p5", txtGözlemciLisansNo.Text);
            komut.Parameters.AddWithValue("@p6", mskGözlemciCepTel.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Gözlemci Ekleme Islemi Basariyla Gercekestirilmistir.");
        }

        void GözlemciTemizle()
        {
            txtGözlemciIsim.Text = "";
            txtGözlemciSoyisim.Text = "";
            cmbGözlemciKlasman.Text = "";
            mskGözlemciTcNo.Text = "";
            txtGözlemciLisansNo.Text = "";
            mskGözlemciCepTel.Text = "";
            txtGözlemciIsim.Focus();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            GözlemciTemizle();
        }
    }
}
