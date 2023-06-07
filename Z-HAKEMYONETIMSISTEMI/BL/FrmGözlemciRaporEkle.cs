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
    public partial class FrmGözlemciRaporEkle : Form
    {
        public FrmGözlemciRaporEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGözlemciRaporOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO GözlemciRapor(GRMacNo,GRHakemIsim,GRTakim1,GRTakim2,GRMacSonuc,GRHakemYorum,GRGözlemciIsim) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtMacNo.Text);
            komut.Parameters.AddWithValue("@p2", txtHakemIsim.Text);
            komut.Parameters.AddWithValue("@p3", cmbTakim1.Text);
            komut.Parameters.AddWithValue("@p4", cmbTakim2.Text);
            komut.Parameters.AddWithValue("@p5", mskMacSonuc.Text);
            komut.Parameters.AddWithValue("@p6", txtHakemYorum.Text);
            komut.Parameters.AddWithValue("@p7", txtGözlemciIsim.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Rapor Yönetime Gönderilmiştir, Müsabakalarınızda Başarılar Dileriz.");
        }
    }
}
